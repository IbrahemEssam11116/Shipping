using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shiping.Services.Models.Auth;
using Shiping.Services.Services;
using Shipping.Models;

namespace Shipping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly ClientSevice _clientSevice;
        private readonly EmployeeService _employeeService;
        private readonly AuthService _authService;
        public UserController(AuthService authService, IHttpContextAccessor httpContextAccessor, EmployeeService employeeService, ClientSevice clientSevice) : base(authService, httpContextAccessor)
        {
            _employeeService = employeeService;
            _clientSevice = clientSevice;
            _authService=authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginVM login)
        {
            var res = await _employeeService.Login(login);
            if (res.Status == Models.ResponseStatus.Success)
                return Ok(res);
            res = await _clientSevice.Login(login);
            return Ok(res);
        }

        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM vm)
        {
            BaseResponse<bool> response = await _authService.ForgetPassword(vm);
            return Ok(response);
        }
        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM vm)
        {
            if (_authService.CurrentUser == null)
            {
                return Ok(new BaseResponse<bool>()
                {
                    Status = ResponseStatus.UnAuthorized,
                });
            }
            BaseResponse<bool> response = await _authService.ChangePassword(vm);
            return Ok(response);
        }
    }
}
