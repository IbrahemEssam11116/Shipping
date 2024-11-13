using AutoMapper;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using PrimeDealsRealestat.Repository.Data;
using PrimeDealsRealestat.Repository.Interfaces;
using Shiping.Repository.Models;
using Shiping.Services.Enum;
using Shiping.Services.Models.Auth;
using Shiping.Services.Models.Employee;
using Shipping.Models;
using static Shiping.Services.Models.Employee.ClientCODVM;

namespace Shiping.Services.Services
{
    class EmployeeOrdersByStatusDto
    {
        public int id { get; set; }
        public List<OrderStatusCountVM> OrdersByStatus { get; set; }

    }
    public class EmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Employee> _employeeRepository;
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IGenericRepository<Permissrion> _permissionRepository;
        private readonly IGenericRepository<Status> _statusRepository;
        private readonly IGenericRepository<City> _cityRepository;
        private readonly IGenericRepository<Client> _ClientRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AuthService _authService;


        public EmployeeService(IMapper mapper, IGenericRepository<Employee> employeeRepository, IUnitOfWork unitOfWork, AuthService authService, IGenericRepository<Order> orderRepository, IGenericRepository<Status> statusRepository, IGenericRepository<Permissrion> permissionRepository, IGenericRepository<City> cityRepository, IGenericRepository<Client> clientRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
            _authService = authService;
            _orderRepository = orderRepository;
            _statusRepository = statusRepository;
            _permissionRepository = permissionRepository;
            _cityRepository = cityRepository;
            _ClientRepository = clientRepository;
        }

        public async Task<BaseResponse<bool>> AddEmployee(AddEmployeeVM vm, Language languageId)
        {
            var user = await _ClientRepository.FindByCondition(w => w.UserName == vm.UserName && w.IsDeleted == true);
            if (user.Any())
            {
                return new BaseResponse<bool>()
                {
                    Result = false,
                    Status = ResponseStatus.Error,
                    Message = "User Name Alredy Exist "
                };
            }
            var emp = await _employeeRepository.FindByCondition(w => w.UserName == vm.UserName && w.IsDeleted == false);
            if (emp.Any())
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.english ? "User Name Alredy Exist" : "المستخدم موجود بالفعل",
                };
            }
            if (vm.EmployeeTypeId == 0)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.english ? "Must Chose Type" : "يجب اختيار نوع المستخدم ",
                };
            }
            var defaultPermission = await _permissionRepository.FindByCondition(w => w.EmployeeTypeId == vm.EmployeeTypeId);
            var employeeToAdd = _mapper.Map<Employee>(vm);
            employeeToAdd.EmployeePermissions = defaultPermission.Select(w => new EmployeePermission()
            {
                permissrionId = w.Id
            }).ToList();
            await _employeeRepository.Add(employeeToAdd);
            await _unitOfWork.Save();
            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = true
            };
        }

        public async Task<BaseResponse<DashBoardViewModel>> GetDashBord(Language languageId)
        {
            var status = await _statusRepository.FindByCondition();
            int? ClientId = null;
            if (_authService.CurrentUser != null && _authService.CurrentUser.IsAdmin == false)
            {
                ClientId = _authService.CurrentUser.UserId;
            }

            DashBoardViewModel vm = new DashBoardViewModel()
            {
            };
            if (ClientId != null)
            {
                var orders = await _orderRepository.FindByCondition(w => w.IsDeleted == false && w.ClientId == ClientId, w => w.Include(w => w.Status).Include(e => e.City));
                //var  Eorders = orders.ToList();
                var statusSummaries = status.ToList()
                .GroupJoin(
                    orders,
                    status => status.Id,
                    order => order.StatusId,
                    (status, orders) => new DashBordVM
                    {
                        StatusId = status.Id,
                        StatusName = languageId == Language.english ? status.Name : status.NameAr,
                        CountOfOrders = orders.Count()
                    }
                ).ToList();


                vm.StatusSummaries = statusSummaries;

                var allorders = orders.ToList();
                var citys = await _cityRepository.GetAll();
                var citylist = citys.ToList();
                var mostOrders = allorders.GroupBy(w => w.CityId).Select(w => new DashBordVM() { CountOfOrders = w.Count(), StatusName = languageId == Language.arabic ? citylist.FirstOrDefault(e => e.Id == w.Key).NameAr : citylist.FirstOrDefault(e => e.Id == w.Key).Name }).OrderByDescending(w => w.CountOfOrders).FirstOrDefault();
                if (mostOrders != null)
                {
                    statusSummaries.Add(mostOrders);
                }
                var codOrders = allorders.Where(w => w.StatusId == (int)StatusEnum.CODReceived && w.IsDeleted == false);
                var client = await _ClientRepository.FindByCondition(w => w.IsDeleted == false && w.Id == ClientId);
                vm.ClientCOD = new ClientCODVM()
                {
                    TotalCODItem = codOrders?.Count() ?? 0,
                    TotalCODAmount = (int)client.Sum(w => w.TotalBalance),
                };
            }
            else
            {
                //var statusSummaries = status.Select(w => new DashBordVM()
                //{
                //    StatusId = w.Id,
                //    StatusName = languageId == Language.arabic ? w.NameAr : w.Name,
                //    CountOfOrders = w.OrderCount,
                //}).ToList();
                var orders = await _orderRepository.FindByCondition(w => w.IsDeleted == false , w => w.Include(w => w.Status).Include(e => e.City));
                var statusSummaries = status.ToList()
               .GroupJoin(
                   orders,
                   status => status.Id,
                   order => order.StatusId,
                   (status, orders) => new DashBordVM
                   {
                       StatusId = status.Id,
                       StatusName = languageId == Language.english ? status.Name : status.NameAr,
                       CountOfOrders = orders.Count()
                   }
               ).ToList();
                //var orders = await _orderRepository.FindByCondition(w => w.IsDeleted == false && w.StatusId == (int)StatusEnum.CODReceived, w => w.Include(w => w.Status));
                var codOrders = orders.Where(w=>w.StatusId == (int)StatusEnum.CODReceived).ToList();
                vm.StatusSummaries = statusSummaries;
                var client = await _ClientRepository.FindByCondition(w => w.IsDeleted == false);

                vm.ClientCOD = new ClientCODVM()
                {
                    TotalCODItem = codOrders?.Count() ?? 0,
                    TotalCODAmount = (int)client.Sum(w => w.TotalBalance),
                };
            }
            return new BaseResponse<DashBoardViewModel>() { Status = ResponseStatus.Success, Result = vm };
        }

        public async Task<BaseResponse<EmployeeVM>> GetEmployee(int employeeId, Language languageId)
        {
            var emp = await _employeeRepository.FindByCondition(w => w.Id == employeeId && w.IsDeleted == false, w => w.Include(w => w.District)
                                                                                          .Include(w => w.City).Include(w => w.EmployeePermissions).ThenInclude(w => w.permissrion));
            if (!emp.Any())
            {
                return new BaseResponse<EmployeeVM>()
                {
                    Message = languageId == Language.english ? "Employee Not Found" : "غير موجود",
                    Status = ResponseStatus.Error
                };
            }
            return new BaseResponse<EmployeeVM>()
            {
                Status = ResponseStatus.Success,
                Result = _mapper.Map<EmployeeVM>(emp.FirstOrDefault(), opts => opts.Items["LanguageId"] = (int)languageId)
            };
        }

        public async Task<BaseResponse<LoginResponseVM>> Login(LoginVM vM)
        {
            var employess = await _employeeRepository.FindByCondition(w => w.UserName == vM.UserName && w.Password == vM.Password,
                                                                    a => a.Include(w => w.City).Include(w => w.District).Include(w => w.EmployeeType).Include(w => w.EmployeePermissions).ThenInclude(w => w.permissrion));

            if (!employess.Any())
            {
                return new BaseResponse<LoginResponseVM>()
                {
                    Status = ResponseStatus.Error,
                    Message = "ErrorLogin",
                    Result = null,

                };
            }

            var emp = employess.FirstOrDefault();
            emp.FCMToken = vM.FCMToken;
            _employeeRepository.Update(emp);
            await _unitOfWork.Save();
            var permiss = emp.EmployeePermissions.Select(w => w.permissrion?.Name).ToList();
            permiss.Add(emp.EmployeeType.Name);
            if (emp.EmployeeTypeId== (int)EmployeeTypeEnum.Warehouse) {

                permiss.Add("CallCenter");
            }
            var token = _authService.GenerateJWT(new UserDataForToken()
            {
                IsAdmin = true,
                UserId = emp.Id,
                UserName = emp.UserName,
                UserTypeName = emp.EmployeeTypeId == (int)EmployeeTypeEnum.Warehouse ? "CallCenter": emp.EmployeeType.Name,
                UserType = emp.EmployeeTypeId == (int)EmployeeTypeEnum.Warehouse? (int)EmployeeTypeEnum.CallCenter :  emp.EmployeeTypeId,
                Permissions = permiss.Distinct().ToList(),
            });
            return new BaseResponse<LoginResponseVM>
            {
                Status = ResponseStatus.Success,
                Result = new LoginResponseVM()
                {
                    Token = token,
                    IsEmployee = true,
                    Permissions = permiss.Distinct().ToList(),
                    Employee = _mapper.Map<EmployeeVM>(emp, opts => opts.Items["LanguageId"] = (int)Language.arabic),

                },
            };
        }

        public async Task<BaseResponse<PaginatedList<EmployeeVM>>> SearchEmployee(SearchEmployeeVM vm, Language languageId)
        {

            var emp = await _employeeRepository.GetByFilterWithPagination(w => ((vm.PhoneNumber == null || w.PhoneNumber.Contains(vm.PhoneNumber)) && w.IsDeleted == false &&
                                                                                (vm.EmployeeTypeId == null || w.EmployeeTypeId == vm.EmployeeTypeId) &&
                                                                                (vm.Title == null || w.title.ToLower().Contains(vm.Title.ToLower())) &&
                                                                                (vm.CityId == null || w.CityId == vm.CityId) &&
                                                                     (vm.Name == null || w.UserName.Contains(vm.Name)))
                                                                     , vm.pageNumber, vm.pageSize,
                                                                     w => w.Include(w => w.City).Include(w => w.District).Include(w => w.Orders).ThenInclude(w => w.Status).Include(w => w.EmployeePermissions).ThenInclude(w => w.permissrion));
            var ordercounts = emp.Data.Select(w => new EmployeeOrdersByStatusDto()
            {
                id = w.Id,
                OrdersByStatus = w.Orders
                    .GroupBy(o => o.Status)
                    .Select(g => new OrderStatusCountVM
                    {
                        Id = g.Key.Id,
                        StatusName = languageId == Language.english ? g.Key.Name : g.Key.NameAr,
                        Count = g.Count()
                    }).ToList()
            });
            var response = _mapper.Map<PaginatedList<EmployeeVM>>(emp, opts => opts.Items["LanguageId"] = (int)languageId);
            foreach (var item in response.Data)
            {
                item.OrdersDeliveredCount = ordercounts?.FirstOrDefault(a => a.id == item.Id)?.OrdersByStatus?.FirstOrDefault(w => w.Id == (int)StatusEnum.CODReceived)?.Count ?? 0;
                var per = emp.Data.FirstOrDefault(w => w.Id == item.Id).EmployeePermissions.Select(w => new EmployeePermissionVM()
                {
                    Id = w.permissrion.Id,
                    PermissionName = languageId == Language.english ? w.permissrion.Name : w.permissrion.NameAr,
                });
                item.EmployeePermissions = per.ToList();
            }
            response.Data.ForEach(w => w.OrdersByStatus = ordercounts.FirstOrDefault(a => a.id == w.Id)?.OrdersByStatus ?? new List<OrderStatusCountVM>());
            return new BaseResponse<PaginatedList<EmployeeVM>>()
            {
                Status = ResponseStatus.Success,
                Result = response,
            };
        }

        public async Task<BaseResponse<bool>> UpdateEmployee(UpdateEmployeeVM vm, Language languageId)
        {
            var employes = await _employeeRepository.FindByCondition(w => w.Id == vm.Id, w => w.Include(e => e.EmployeePermissions));
            if (!employes.Any())
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "Employee Not Found" : "الموظف غير موجود",
                };
            }
            var emp = employes.FirstOrDefault();
            emp.CityId = vm.CityId;
            emp.EmployeeTypeId = vm.EmployeeTypeId;
            emp.DistrictId = vm.DistrictId;
            emp.UserName = string.IsNullOrEmpty(vm.UserName) ? emp.UserName : vm.UserName;
            emp.PhoneNumber = string.IsNullOrEmpty(vm.PhoneNumber) ? emp.PhoneNumber : vm.PhoneNumber;
            emp.title = string.IsNullOrEmpty(vm.title) ? emp.title : vm.title;
            emp.Email = string.IsNullOrEmpty(vm.Email) ? emp.Email : vm.Email;
            if (vm.Permissions != null)
            {
                emp.EmployeePermissions = vm.Permissions.Select(w => new EmployeePermission()
                {
                    permissrionId = w,

                }).ToList();
            }
            _employeeRepository.Update(emp);
            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = await _unitOfWork.Save()
            };
        }


        public async Task<BaseResponse<bool>> DeleteEmployee(int employeeId, Language languageId)
        {
            var emp = await _employeeRepository.GetById(employeeId);
            if (emp == null)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "Employee Not Found" : "الموظف غير موجود",
                };
            }
            if (emp.Id == 1)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "Not allow" : "غيرمسموح",
                };
            }


            emp.IsDeleted = true;
            _employeeRepository.Update(emp);
            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = await _unitOfWork.Save(),
            };
        }

        public async Task<BaseResponse<bool>> PayDrivaryOrderCOD(AddDriverAmountVM vm, Language LanguageId)
        {
            var client = await _employeeRepository.GetById(vm.DriveryId);
            if (client == null || client.IsDeleted == true)
            {
                return new BaseResponse<bool>()
                {
                    Message = LanguageId == Language.english ? "Driver Not Found" : "غير موجود",
                    Status = ResponseStatus.Error
                };

            }
            if (client.EmployeeTypeId != (int)EmployeeTypeEnum.Driver)
            {

                return new BaseResponse<bool>()
                {
                    Message = LanguageId == Language.english ? "Employee Not Driver" : "المستخدم ليس سواق",
                    Status = ResponseStatus.Error
                };
            }

            client.DefaultFees = 0;
            _employeeRepository.Update(client);
            await _unitOfWork.Save();
            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = true
            };
        }

        public async Task<BaseResponse<int>> GetDriverAmount(int driverId, Language languageId)
        {

            var client = await _employeeRepository.GetById(driverId);
            if (client == null || client.IsDeleted == true)
            {
                return new BaseResponse<int>()
                {
                    Message = languageId == Language.english ? "Driver Not Found" : "غير موجود",
                    Status = ResponseStatus.Error
                };

            }
            if (client.EmployeeTypeId != (int)EmployeeTypeEnum.Driver)
            {

                return new BaseResponse<int>()
                {
                    Message = languageId == Language.english ? "Employee Not Driver" : "المستخدم ليس سواق",
                    Status = ResponseStatus.Error
                };
            }
            return new BaseResponse<int>
            {
                Status = ResponseStatus.Success,
                Result = ((int?)client.DefaultFees) ?? 0
            };
        }
    }
}
