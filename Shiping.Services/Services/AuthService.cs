using MailKit.Security;
using Microsoft.IdentityModel.Tokens;
using MimeKit;
using PrimeDealsRealestat.Repository.Interfaces;
using Shiping.Repository.Models;
using Shiping.Services.Models.Auth;
using Shipping.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Shiping.Services.Services
{
    public class AuthService
    {


        public UserDataForToken CurrentUser { set; get; }
        private readonly IGenericRepository<Client> _clientRepository;
        private readonly IGenericRepository<Employee> _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AuthService(IGenericRepository<Client> clientRepository, IGenericRepository<Employee> employeeRepository, IUnitOfWork unitOfWork)
        {
            _clientRepository = clientRepository;
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }
        public string GenerateJWT(UserDataForToken userData)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("your-newly-generated-base64-encoded-key");
            var claims = new List<Claim>
        {
                new Claim("UserId", userData.UserId.ToString()),
                new Claim("UserName", userData.UserName),
                new Claim("IsAdmin", userData.IsAdmin.ToString()),
                new Claim("UserType", userData.UserType.ToString()),
                new Claim("UserTypeName", userData.UserTypeName),

        };
            claims.AddRange(userData.Permissions.Select(permission => new Claim(ClaimTypes.Role, permission)));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public UserDataForToken ConvertTokenToLoginModel(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("your-newly-generated-base64-encoded-key"))
            };

            try
            {
                // Validate the token and extract the principal
                var principal = tokenHandler.ValidateToken(token, validationParameters, out var securityToken);

                // Extract claims
                var username = principal.Claims.FirstOrDefault(c => c.Type == "UserName")?.Value;
                var UserId = principal.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
                var IsAdmin = principal.Claims.FirstOrDefault(c => c.Type == "IsAdmin")?.Value;
                var usertype = principal.Claims.FirstOrDefault(c => c.Type == "UserType")?.Value;
                var UserTypeName = principal.Claims.FirstOrDefault(c => c.Type == "UserTypeName")?.Value;
                var roles = principal.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).ToList();

                // Map to LoginModel
                CurrentUser = new UserDataForToken
                {
                    UserName = username,
                    Permissions = roles,
                    UserId = int.Parse(UserId),
                    IsAdmin = bool.Parse(IsAdmin),
                    UserType = int.Parse(usertype),
                    UserTypeName = UserTypeName,
                };
                return CurrentUser;
            }
            catch (Exception ex)
            {
                // Handle token validation exceptions
                throw new SecurityTokenException("Invalid token", ex);
            }
        }

        public async Task<BaseResponse<bool>> ForgetPassword(ForgetPasswordVM vm)
        {
            string email = null;
            var employee = await _employeeRepository.FindByCondition(w => w.UserName == vm.UserName);
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@";
            string newPassword = new string(Enumerable.Repeat(chars, 6)
            .Select(s => s[new Random().Next(s.Length)]).ToArray());
            if (employee.Any())
            {
                var emp = employee.FirstOrDefault();
                email = emp.Email;
                emp.Password = newPassword;
                _employeeRepository.Update(emp);

            }
            else
            {
                var client = await _clientRepository.FindByCondition(w => w.UserName == vm.UserName);
                if (client.Any())
                {
                    var cli = client.FirstOrDefault();
                    email = cli.Email;
                    cli.Password = newPassword;
                    _clientRepository.Update(cli);
                }
            }
            if (string.IsNullOrEmpty(email))
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Message = "User Dosnt Exist",
                };
            }

            var message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse("moonlightfaster@gmail.com"));
            message.To.Add(MailboxAddress.Parse(email));

            message.Subject = "Forget Password";
            var body = new TextPart("plain")
            {
                Text = $"Please Not That New Password is  {newPassword} Dont Share with any one "
            };
            var multipart = new Multipart("mixed");
            multipart.Add(body);

            message.Body = multipart;
            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("moonlightfaster@gmail.com", "audk nggi wrsu qaaz");
            smtp.Send(message);
            smtp.Disconnect(true);
            await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = ResponseStatus.Success,
                Result = true,
            };
        }

        public async Task<BaseResponse<bool>> ChangePassword(ChangePasswordVM vm)
        {
            string email = null;
            var isemployee = CurrentUser?.IsAdmin == true;

            if (CurrentUser != null && isemployee)
            {
                var employee = await _employeeRepository.FindByCondition(w => w.Id == CurrentUser.UserId);
                //string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@";
                //string newPassword = new string(Enumerable.Repeat(chars, 6)
                //.Select(s => s[new Random().Next(s.Length)]).ToArray());
                if (employee.Any())
                {
                    var emp = employee.FirstOrDefault();
                    email = emp.Email;
                    emp.Password = vm.NewPassword;
                    _employeeRepository.Update(emp);

                }
            }
            else if (CurrentUser != null && !isemployee)
            {
                var client = await _clientRepository.FindByCondition(w => w.Id == CurrentUser.UserId);
                if (client.Any())
                {
                    var cli = client.FirstOrDefault();
                    email = cli.Email;
                    cli.Password = vm.NewPassword;
                    _clientRepository.Update(cli);
                }
            }
            if (string.IsNullOrEmpty(email))
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Message = "User Dosnt Exist",
                };
            }
            await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = ResponseStatus.Success,
                Result = true,
            };
        }
    }
}

