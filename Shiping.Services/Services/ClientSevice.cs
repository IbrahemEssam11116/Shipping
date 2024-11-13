using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PrimeDealsRealestat.Repository.Data;
using PrimeDealsRealestat.Repository.Interfaces;
using Shiping.Repository.Models;
using Shiping.Services.Enum;
using Shiping.Services.Models;
using Shiping.Services.Models.Auth;
using Shiping.Services.Models.Client;
using Shiping.Services.Models.Employee;
using Shiping.Services.Models.Order;
using Shipping.Models;

namespace Shiping.Services.Services
{
    public class ClientSevice
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Client> _clientRepository;
        private readonly IGenericRepository<Employee> _employeeRepository;
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AuthService _authService;

        public ClientSevice(IMapper mapper, IGenericRepository<Client> clientRepository, IUnitOfWork unitOfWork, AuthService authService, IGenericRepository<Order> orderRepository, IGenericRepository<Employee> employeeRepository)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;
            _unitOfWork = unitOfWork;
            _authService = authService;
            _orderRepository = orderRepository;
            _employeeRepository = employeeRepository;
        }
        public async Task<BaseResponse<bool>> AddClient(AddClientVM clientVM, bool isAdmin)
        {
            var user = await _clientRepository.FindByCondition(w => w.UserName == clientVM.UserName && w.IsDeleted==true);
            if (user.Any())
            {
                return new BaseResponse<bool>()
                {
                    Result = false,
                    Status = ResponseStatus.Error,
                    Message = "User Name Alredy Exist "
                };
            }
            var emp = await _employeeRepository.FindByCondition(w => w.UserName == clientVM.UserName && w.IsDeleted == true);
            if (emp.Any())
            {
                return new BaseResponse<bool>()
                {
                    Result = false,
                    Status = ResponseStatus.Error,
                    Message = "User Name Alredy Exist "
                };
            }

            var client = _mapper.Map<Client>(clientVM);
            if (isAdmin)
                client.IsActive = isAdmin;
            await _clientRepository.Add(client);
            var isSaved = await _unitOfWork.Save();

            var response = new BaseResponse<bool>()
            {
                Result = isSaved,
                Status = isSaved ? ResponseStatus.Success : ResponseStatus.Error
            };
            return response;
        }

        public async Task<BaseResponse<LoginResponseVM>> Login(LoginVM vM)
        {
            var users = await _clientRepository.FindByCondition(w => w.UserName == vM.UserName && w.Password == vM.Password);
            //var users = new List<Client>() { new Client()
            // {
            //     Id=1,
            //     UserName="aa",

            // } };
            if (!users.Any())
            {
                return new BaseResponse<LoginResponseVM>()
                {
                    Status = ResponseStatus.Error,
                    Message = "ErrorLogin"
                };
            }
            var user = users.FirstOrDefault();
            if (user.IsActive == false)
            {
                return new BaseResponse<LoginResponseVM>()
                {
                    Status = ResponseStatus.Error,
                    Message = "In Active User"
                };
            }
            var per = new List<string>() { "Client" };
            var token = _authService.GenerateJWT(new UserDataForToken()
            {
                IsAdmin = false,
                UserId = user.Id,
                UserName = user.UserName,
                UserType = 0,
                UserTypeName= "Client",
                Permissions = per,
            });
            return new BaseResponse<LoginResponseVM>
            {
                Status = ResponseStatus.Success,
                Result = new LoginResponseVM()
                {
                    Token = token,
                    IsEmployee = false,
                    Permissions=per,
                    Client = _mapper.Map<ClientVM>(user, opts => opts.Items["LanguageId"] = (int)Language.english),
                },
            };
        }
        public async Task<BaseResponse<PaginatedList<ClientVM>>> SrearchClient(SearchClientVM vm, Language languageId, bool? isApproed)
        {
            var clients = await _clientRepository.GetByFilterWithPagination(w => w.IsActive == isApproed &&
                                                                                w.IsDeleted==false&&
                                                                            (vm.UserName == null || w.UserName.ToLower().Contains(vm.UserName.ToLower())) &&
                                                                            (vm.Email == null || w.Email == vm.Email) &&
                                                                            (vm.CompanyName == null || w.CompanyName.ToLower().Contains(vm.CompanyName.ToLower())) &&
                                                                            (vm.PhoneNumber == null || w.PhoneNumber.Contains(vm.PhoneNumber)), vm.pageNumber, vm.pageSize,
                                                                             e => e.Include(w => w.City).Include(w => w.District));

            var pagedData = _mapper.Map<PaginatedList<ClientVM>>(clients, opts => opts.Items["LanguageId"] = (int)languageId);

            return new BaseResponse<PaginatedList<ClientVM>>()
            {
                Status = ResponseStatus.Success,
                Result = pagedData
            };

        }
        public async Task<BaseResponse<PaginatedList<OrderVM>>> MyOrders(PagingVM vM, Language languageId)
        {
            var orders = await _orderRepository.GetByFilterWithPagination(w => w.ClientId == _authService.CurrentUser.UserId,
                                                                     vM.pageNumber, vM.pageSize,
                                                                     w => w.Include(w => w.Status).Include(w => w.Client).Include(w => w.City)
                                                                     .Include(w => w.District).Include(w => w.Drivery));

            var pagedData = _mapper.Map<PaginatedList<OrderVM>>(orders, opts => opts.Items["LanguageId"] = (int)languageId);
            return new BaseResponse<PaginatedList<OrderVM>>()
            {
                Status = ResponseStatus.Success,
                Result = pagedData,
            };
        }

        public async Task<BaseResponse<bool>> ApproveRejectClientVM(ApproveRejectClientVM vm, Language languageId)
        {
            var clients = await _clientRepository.FindByCondition(w => vm.ClientIds.Contains(w.Id));
            foreach (var client in clients)
            {
                client.IsActive = vm.Status;
                _clientRepository.Update(client);
            }
            await _unitOfWork.Save();
            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = true,
            };
        }

        public async Task<BaseResponse<bool>> DeleteClient(int clientId, Language languageId)
        {
            var client = await _clientRepository.GetById(clientId);
            if (client == null)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "client Not Found" : " غير موجود",
                };
            }


            client.IsDeleted = true;
            _clientRepository.Update(client);
            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = await _unitOfWork.Save(),
            };
        }

        public async Task<BaseResponse<bool>> EditClient(EditClientVM vm, Language languageId)
        {
            var client =await _clientRepository.GetById(vm.Id);
            if (client == null)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "client Not Found" : " غير موجود",
                };
            }

            client.CompanyName = vm.CompanyName;
            client.PhoneNumber = vm.PhoneNumber;
            client.Email = vm.Email;
            client.Address = vm.Address;
            client.CityId = vm.CityId;
            client.DistrictId = vm.DistrictId;
            _clientRepository.Update(client);
            await _unitOfWork.Save();
            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = await _unitOfWork.Save(),
            };
        }

        public async Task<BaseResponse<ClientVM>> GetClient(int clientId, Language languageId)
        {
            var clients = await _clientRepository.FindByCondition(w => w.Id ==clientId ,
                                                                 w => w.Include(w => w.City).Include(w => w.District));

            var clientVM = _mapper.Map<ClientVM>(clients.FirstOrDefault(), opts => opts.Items["LanguageId"] = (int)languageId);

            return new BaseResponse<ClientVM>()
            {
                Status = ResponseStatus.Success,
                Result = clientVM
            };
        }


    }
}
