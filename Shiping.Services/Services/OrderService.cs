using AutoMapper;
//using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MimeKit;
using PrimeDealsRealestat.Repository.Data;
using PrimeDealsRealestat.Repository.Interfaces;
using Shiping.Repository.Models;
using Shiping.Services.Enum;
using Shiping.Services.Models.Lookupa;
using Shiping.Services.Models.Order;
using Shipping.Models;
using MailKit.Net.Smtp;
using System.Net.Mail;
using System.Net;
using MailKit.Security;
using Spire.Xls;
using ClosedXML.Excel;
using System.Linq;
namespace Shiping.Services.Services
{

    public class OrderService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IGenericRepository<District> _districtRepository;
        private readonly IGenericRepository<City> _cityRepository;
        private readonly IGenericRepository<Status> _statusRepository;
        private readonly IGenericRepository<OrderHistory> _orderHistoryRepository;
        private readonly IGenericRepository<Client> _ClientRepository;
        private readonly IGenericRepository<Employee> _employeeRepository;
        private readonly IGenericRepository<Material> _materialRepository;
        private readonly IGenericRepository<Repository.Models.OrderType> _orderTypeRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AuthService _authService;
        private readonly IConfiguration _configuration;
        private readonly FirebaseHttpClientService _fireBaseService;

        public OrderService(IMapper mapper, IGenericRepository<Order> orderRepository, IUnitOfWork unitOfWork, AuthService authService, IGenericRepository<City> cityRepository, IGenericRepository<District> districtRepository, IGenericRepository<Status> statusRepository, IConfiguration configuration, IGenericRepository<OrderHistory> orderHistoryRepository, IGenericRepository<Client> clientRepository, FirebaseHttpClientService fireBaseService, IGenericRepository<Material> materialRepository, IGenericRepository<Repository.Models.OrderType> orderTypeRepository, IGenericRepository<Employee> employeeRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
            _authService = authService;
            _cityRepository = cityRepository;
            _districtRepository = districtRepository;
            _statusRepository = statusRepository;
            _configuration = configuration;
            _orderHistoryRepository = orderHistoryRepository;
            _ClientRepository = clientRepository;
            _fireBaseService = fireBaseService;
            _materialRepository = materialRepository;
            _orderTypeRepository = orderTypeRepository;
            _employeeRepository = employeeRepository;
        }

        public async Task<BaseResponse<bool>> AddOrder(AddOrderVM vM)
        {
            var order = _mapper.Map<Order>(vM);
            order.StatusId = (int)StatusEnum.New;
            //order.DriveryId = null;

            var city = await _cityRepository.GetById(vM.CityId);
            order.OrderFees = city.Fees;
            //order.Amount=vM,
            if (_authService.CurrentUser?.IsAdmin == false && vM.ClientId == null)
            {
                order.ClientId = _authService.CurrentUser.UserId;
            }
            var client = await _ClientRepository.GetById(order.ClientId);
            order.OrderHistories = new List<OrderHistory>(){new OrderHistory()
            {
                 StatusId= (int)StatusEnum.New,
                 EmployeeId= _authService.CurrentUser?.IsAdmin==true? _authService.CurrentUser.UserId:null,
                 UserName= _authService.CurrentUser?.UserName??"Admin",
            } };

            if (order.Weight > 1)
            {
                int weightSalary = int.Parse(_configuration["DefaultWeight"]);
                order.DriveryFees = order.DriveryFees + ((order.Weight - 1) * weightSalary);
            }
            if (vM.MaterialIds?.Any() == true)
            {
                var material = await _materialRepository.FindByCondition(w => vM.MaterialIds.Any(e => e == w.Id));
                order.MaterialFees = material.Sum(w => w.Price);


                order.OrderMaterials = material.Select(w => new OrderMaterial()
                {
                    MaterialId = w.Id,
                }).ToList();

            }
            order.Recipient = "Recipient";
            await _orderRepository.Add(order);
            var sta = await _statusRepository.GetById(order.StatusId);
            sta.OrderCount++;
            _statusRepository.Update(sta);
            await _unitOfWork.Save();
            var employeeToken = _employeeRepository.FindByCondition(w => w.IsDeleted == false && w.FCMToken != null).Result.Select(w => w.FCMToken).ToList();
            await _fireBaseService.SendNotificationToTokensAsync(employeeToken, "New Order", $"New Ordr Added To Client {client.UserName} With Id {order.Id}");
            await _fireBaseService.SendNotificationToTopicAsync("add_order", "New Order", $"New Ordr Added To Client {client.UserName} With Id {order.Id}");
            return new BaseResponse<bool>
            {
                Status = ResponseStatus.Success,
                Result = true
            };
        }

        public async Task<BaseResponse<bool>> ChangeOrderFees(ChangeOrderFeesVM vm, Language languageId)
        {
            var order = await _orderRepository.GetById(vm.OrderId);
            if (order == null)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.english ? "Not Found" : "غير موجود",
                };
            }
            if (order.StatusId == (int)StatusEnum.Delivered || order.StatusId == (int)StatusEnum.CODReceived || order.StatusId == (int)StatusEnum.Cancelled || order.StatusId == (int)StatusEnum.NotReceived || order.StatusId == (int)StatusEnum.Paid)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.english ? "Cant Change Fees for current Status " : "لا يمكن تغير الحسالب لحالة الطلب الحالية",
                };
            }

            order.OrderFees = vm.Fees;
            _orderRepository.Update(order);
            await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = ResponseStatus.Success,
                Result = true,
            };
        }

        public async Task<BaseResponse<bool>> DeleteOrders(DeleteOrdersVM vm)
        {
            var orders = await _orderRepository.FindByCondition(w => vm.OrderIds.Contains(w.Id));
            var statuses = await _statusRepository.GetAll();
            foreach (var item in orders)
            {
                if (item.StatusId != (int) StatusEnum.CODReceived 
                        && (item.StatusId != (int)StatusEnum.FailedFeesCollected ||(item.StatusId == (int)StatusEnum.FailedFeesCollected && item.DisAllowShowInPayment))
                        &&   (item.StatusId == (int)StatusEnum.CustomerCancelled || (item.StatusId == (int)StatusEnum.CustomerCancelled && item.DisAllowShowInPayment)))
                {

                if (item.IsDeleted == false)
                {
                
                    statuses.FirstOrDefault(w => w.Id == item.StatusId).OrderCount = statuses.FirstOrDefault(w => w.Id == item.StatusId).OrderCount > 0 ? statuses.FirstOrDefault(w => w.Id == item.StatusId).OrderCount - 1 : 0;
                }
                item.IsDeleted = true;

                _orderRepository.Update(item);
                }
            }
            foreach (var item in statuses)
            {
                _statusRepository.Update(item);
            }
            await _unitOfWork.Save();
            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = true,
            };
        }

        public async Task<BaseResponse<OrderDetailsvm>> GetById(int id, Language languageId)
        {
            var orders = await _orderRepository.FindByCondition(w => w.Id == id,
                                                                          w => w.Include(w => w.Status).Include(w => w.Client).Include(w => w.City)
                                                                          .Include(w => w.District).Include(w => w.Drivery).Include(w => w.OrderMaterials).Include(w => w.OrderType)
                                                                          .Include(w => w.OrderHistories).ThenInclude(w => w.Status));

            var orderStatus = await _statusRepository.GetAll();
            if (!orders.Any())
            {
                return new BaseResponse<OrderDetailsvm>()
                {
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.english ? "Not Found" : "غير موجود",
                };
            }
            var res = _mapper.Map<OrderDetailsvm>(orders.FirstOrDefault(), opts => opts.Items["LanguageId"] = (int)languageId);
            res.AvailableStatus = NextStatus((StatusEnum)res.StatusId).Select(w => new lokkupVM()
            {
                Id = w,
                Name = languageId == Language.english ? orderStatus.Find(a => a.Id == w)?.Name : orderStatus.Find(a => a.Id == w)?.NameAr
            }).ToList();
            return new BaseResponse<OrderDetailsvm>()
            {
                Status = ResponseStatus.Success,
                Result = _mapper.Map<OrderDetailsvm>(orders.FirstOrDefault(), opts => opts.Items["LanguageId"] = (int)languageId),
            };

        }

        public async Task<BaseResponse<PaginatedList<OrderVM>>> SearchOrder(SearchOrderVM vm, Language languageId)
        {
            var orders = await _orderRepository.GetByFilterWithPagination(w => w.IsDeleted == false &&
                                                                                (vm.DriverId == null || w.DriveryId == vm.DriverId) &&
                                                                                (vm.StatusId == null || w.StatusId == vm.StatusId) &&
                                                                                (vm.OrderCodes == null || !vm.OrderCodes.Any() || vm.OrderCodes.Any(s => s == w.Id)) &&
                                                                                (vm.ClietId == null || w.ClientId == vm.ClietId) &&
                                                                                (vm.Day == null || w.CreatedAt.Date == vm.Day.Value.Date) &&
                                                                                (vm.From == null || w.CreatedAt.Date >= vm.From.Value.Date) &&
                                                                                (vm.To == null || w.CreatedAt.Date <= vm.To.Value.Date) &&
                                                                                (vm.MobileNumber == null || w.MobileNumber == vm.MobileNumber) &&
                                                                                (vm.DistrictId == null || w.DistrictId <= vm.DistrictId) &&
                                                                                (vm.CityId == null || w.CityId <= vm.CityId)

                                                                                ,
                                                                          vm.pageNumber, vm.pageSize,
                                                                          w => w.Include(w => w.Status).Include(w => w.Client).Include(w => w.City)
                                                                          .Include(w => w.District).Include(w => w.Drivery).Include(w => w.OrderMaterials).Include(w => w.OrderType));

            var orderStatus = await _statusRepository.GetAll();

            var pagedData = _mapper.Map<PaginatedList<OrderVM>>(orders, opts => opts.Items["LanguageId"] = (int)languageId);

            foreach (var item in pagedData.Data)
            {
                var nextStatusList = NextStatus((StatusEnum)item.StatusId);
                item.AvailableStatus = nextStatusList.Select(w => new lokkupVM()
                {
                    Id = w,
                    Name = languageId == Language.english ? orderStatus.Find(a => a.Id == w)?.Name : orderStatus.Find(a => a.Id == w)?.NameAr
                }).ToList();
            }
            return new BaseResponse<PaginatedList<OrderVM>>()
            {
                Status = ResponseStatus.Success,
                Result = pagedData,
            };
        }
        public async Task<BaseResponse<List<OrderVM>>> GetPaymentOrder(GetPaymentOrderVM vm, Language languageId)
        {
            var orders = await _orderRepository.FindByCondition(w => w.IsDeleted == false && w.DisAllowShowInPayment == false &&
                                                                                (vm.DriverId == null || w.DriveryId == vm.DriverId) &&
                                                                                (w.StatusId == (int)StatusEnum.CODReceived || w.StatusId == (int)StatusEnum.CustomerCancelled || w.StatusId == (int)StatusEnum.FailedFeesCollected) &&
                                                                                (vm.OrderCode == null || w.Id == vm.OrderCode) &&
                                                                                (vm.ClietId == null || w.ClientId == vm.ClietId) &&
                                                                                (vm.Day == null || w.CreatedAt.Date == vm.Day.Value.Date) &&
                                                                                (vm.From == null || w.CreatedAt.Date >= vm.From.Value.Date) &&
                                                                                (vm.To == null || w.CreatedAt.Date <= vm.To.Value.Date),

                                                                          w => w.Include(w => w.Status).Include(w => w.Client).Include(w => w.City)
                                                                          .Include(w => w.District).Include(w => w.Drivery).Include(w => w.OrderMaterials).Include(w => w.OrderType));

            var orderStatus = await _statusRepository.GetAll();

            var pagedData = _mapper.Map<List<OrderVM>>(orders, opts => opts.Items["LanguageId"] = (int)languageId);

            foreach (var item in pagedData)
            {
                var nextStatusList = NextStatus((StatusEnum)item.StatusId);
                item.AvailableStatus = nextStatusList.Select(w => new lokkupVM()
                {
                    Id = w,
                    Name = languageId == Language.english ? orderStatus.Find(a => a.Id == w)?.Name : orderStatus.Find(a => a.Id == w)?.NameAr
                }).ToList();
            }
            return new BaseResponse<List<OrderVM>>()
            {
                Status = ResponseStatus.Success,
                Result = pagedData,
            };
        }

        public bool isAllowChangeStatus(int statusId)
        {
            var isclient = !_authService.CurrentUser?.IsAdmin;
            if (isclient == true)
            {
                return false;
            }
            else if (isclient == false)
            {
                if (_authService.CurrentUser.UserType == (int)EmployeeTypeEnum.Driver)
                {
                    return statusId == (int)StatusEnum.Delivered || statusId == (int)StatusEnum.Cancelled;
                }
                else if(_authService.CurrentUser.UserType == (int)EmployeeTypeEnum.Accountant|| _authService.CurrentUser.UserType == (int)EmployeeTypeEnum.Admin)
                {
                    return true;
                }
                else if (_authService.CurrentUser.UserType == (int)EmployeeTypeEnum.Support || _authService.CurrentUser.UserType == (int)EmployeeTypeEnum.CallCenter|| _authService.CurrentUser.UserType==(int)EmployeeTypeEnum.Warehouse)
                {
                    return !(statusId == (int)StatusEnum.FailedFeesCollected || statusId == (int)StatusEnum.CODReceived || statusId == (int)StatusEnum.CustomerCancelled);
                }
                else
                {
                    return false;
                }
            
            }
            else
            {
                return false;
            }
        }


        public List<int> NextStatus(StatusEnum status)
        {
            List<int> nextStatus = new List<int>();
            switch (status)
            {
                case StatusEnum.New:
                    nextStatus.Add((int)StatusEnum.Preparing);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    break;
                case StatusEnum.Preparing:
                    nextStatus.Add((int)StatusEnum.PickedUp);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);

                    break;
                case StatusEnum.PickedUp:
                    nextStatus.Add((int)StatusEnum.Shipped);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);

                    break;
                case StatusEnum.Shipped:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.Delivered:
                    //nextStatus.Add((int)StatusEnum.Failed);
                    //nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    //nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    //nextStatus.Add((int)StatusEnum.ClientReschedule);
                    //nextStatus.Add((int)StatusEnum.Cancelled);
                    //nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    //nextStatus.Add((int)StatusEnum.NotReceived);
                    //nextStatus.Add((int)StatusEnum.CODReceived);
                    //nextStatus.Add((int)StatusEnum.MissingInfo);
                    //nextStatus.Add((int)StatusEnum.OnHold);
                    //nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    //nextStatus.Add((int)StatusEnum.NotReady);
                    //nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    //nextStatus.Add((int)StatusEnum.Resend);
                    //nextStatus.Add((int)StatusEnum.Duplicated);
                    //nextStatus.Add((int)StatusEnum.ClientReschedule);
                    //nextStatus.Add((int)StatusEnum.MissingPiece);
                    //nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.Failed:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.FailedFeesCollected:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.CouldNotReachClient:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.ClientReschedule:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.Cancelled:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.ReturnedToShipper:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.NotReceived:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.CODReceived:
                    break;
                case StatusEnum.MissingInfo:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.OnHold:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.CustomerCancelled:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.NotReady:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.ReceivedAtWarehouse:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.Resend:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.Ready:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);

                    break;
                case StatusEnum.Duplicated:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.MissingPiece);
                    nextStatus.Add((int)StatusEnum.Ready);

                    break;
                case StatusEnum.MissingPiece:
                    nextStatus.Add((int)StatusEnum.Delivered);
                    nextStatus.Add((int)StatusEnum.Failed);
                    nextStatus.Add((int)StatusEnum.FailedFeesCollected);
                    nextStatus.Add((int)StatusEnum.CouldNotReachClient);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Cancelled);
                    nextStatus.Add((int)StatusEnum.ReturnedToShipper);
                    nextStatus.Add((int)StatusEnum.NotReceived);
                    nextStatus.Add((int)StatusEnum.CODReceived);
                    nextStatus.Add((int)StatusEnum.MissingInfo);
                    nextStatus.Add((int)StatusEnum.OnHold);
                    nextStatus.Add((int)StatusEnum.CustomerCancelled);
                    nextStatus.Add((int)StatusEnum.NotReady);
                    nextStatus.Add((int)StatusEnum.ReceivedAtWarehouse);
                    nextStatus.Add((int)StatusEnum.Resend);
                    nextStatus.Add((int)StatusEnum.Duplicated);
                    nextStatus.Add((int)StatusEnum.ClientReschedule);
                    nextStatus.Add((int)StatusEnum.Ready);
                    break;
                default:
                    break;

            }
            return nextStatus;

        }
        public async Task<BaseResponse<bool>> ChangeOrderStatus(ChangeOrderStatusVM vm, Language languageId)
        {
            
            if (vm.OrderIds?.Any() == false)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "not found" : "not found"

                };
            }
            if (vm.StatusId == (int)StatusEnum.Paid) {

                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.english ? "Cant Change to this status Of this Order" : "لا يمكن تغير حالة هذا الطلب"
                };
            }
            var ordersQyery = await _orderRepository.FindByCondition(w => vm.OrderIds.Any(a => a == w.Id));
            var orders = ordersQyery.ToList();
            if (orders.Any(w => w.StatusId == (int)StatusEnum.CODReceived) || orders.Any(w => w.StatusId == (int)StatusEnum.CustomerCancelled) || orders.Any(w => w.StatusId == (int)StatusEnum.FailedFeesCollected) || orders.Any(w => w.StatusId == (int)StatusEnum.Paid))
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.english ? "Cant Change to this status Of this Order" : "لا يمكن تغير حالة هذا الطلب"
                };
            }
            if ((vm.StatusId == (int)StatusEnum.CODReceived || vm.StatusId == (int)StatusEnum.CustomerCancelled || vm.StatusId == (int)StatusEnum.FailedFeesCollected) && orders.Any(w => w.DriveryId == null))
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.english ? "Cant Change to this status without  chose driver" : "لا يمكن أختيار هذة الحالة بدون اختيار سايق"
                };
            }
            foreach (var order in orders)
            {
                //var order = await _orderRepository.GetById(orderId);
                if (order == null)
                {
                    return new BaseResponse<bool>()
                    {
                        Status = ResponseStatus.Error,
                        Result = false,
                        Message = languageId == Language.english ? "Order not found" : "لم يتم العثور على الطلب"
                    };
                }

                // Early exit if the order has any of the restricted statuses
                if (order.StatusId == (int)StatusEnum.CODReceived || order.StatusId == (int)StatusEnum.CustomerCancelled || order.StatusId == (int)StatusEnum.FailedFeesCollected)
                {
                    return new BaseResponse<bool>()
                    {
                        Status = ResponseStatus.Error,
                        Message = languageId == Language.english ? "Can't change to this status for this order" : "لا يمكن تغيير حالة هذا الطلب"
                    };
                }

                // Early exit if trying to change to restricted status without assigning a driver
                if ((vm.StatusId == (int)StatusEnum.CODReceived || vm.StatusId == (int)StatusEnum.CustomerCancelled || vm.StatusId == (int)StatusEnum.FailedFeesCollected) && order.DriveryId == null)
                {
                    return new BaseResponse<bool>()
                    {
                        Status = ResponseStatus.Error,
                        Message = languageId == Language.english ? "Can't change to this status without choosing a driver" : "لا يمكن أختيار هذة الحالة بدون اختيار سايق"
                    };
                }

                var oldstatus = await _statusRepository.GetById(order.StatusId);
                oldstatus.OrderCount = oldstatus.OrderCount > 0 ? oldstatus.OrderCount - 1 : 0;
                order.StatusId = vm.StatusId;
                var newStatus = await _statusRepository.GetById(vm.StatusId);
                newStatus.OrderCount++;
                _orderRepository.Update(order);
                _statusRepository.Update(oldstatus);
                _statusRepository.Update(newStatus);

                OrderHistory hes = new OrderHistory()
                {
                    OrderId = order.Id,
                    StatusId = vm.StatusId,
                    UserName = _authService.CurrentUser.UserName
                };
                await _orderHistoryRepository.Add(hes);

                // Update balance if status changes to CODReceived or CustomerCancelled
                if (order.StatusId == (int)StatusEnum.CODReceived)
                {
                    var client = await _ClientRepository.GetById(order.ClientId);
                    client.TotalBalance += order.Amount;
                    _ClientRepository.Update(client);

                    var driver = await _employeeRepository.GetById(order.DriveryId.Value);
                    driver.DefaultFees += 1;
                    _employeeRepository.Update(driver);
                }
                else if (order.StatusId == (int)StatusEnum.CustomerCancelled)
                {
                    var client = await _ClientRepository.GetById(order.ClientId);
                    client.TotalBalance -= ((order.MaterialFees ?? 0) + order.DriveryFees + order.OrderFees);
                    _ClientRepository.Update(client);
                }
            }

            await _unitOfWork.Save();

            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = true,
            };
        }

        //public async Task<BaseResponse<bool>> ChangeOrderStatus(ChangeOrderStatusVM vm, Language languageId)
        //{
        //    var orders = await _orderRepository.FindByCondition(w => vm.OrderIds.Any(a => a == w.Id));
        //    if (orders == null)
        //    {
        //        return new BaseResponse<bool>()
        //        {
        //            Status = ResponseStatus.Error,
        //            Result = false,
        //            Message = languageId == Language.english ? "Not Found" : "Not Found"

        //        };
        //    }
        //    if (orders.Any(w => w.StatusId == (int)StatusEnum.CODReceived) || orders.Any(w => w.StatusId == (int)StatusEnum.CustomerCancelled) || orders.Any(w => w.StatusId == (int)StatusEnum.FailedFeesCollected))
        //    {
        //        return new BaseResponse<bool>()
        //        {
        //            Status = ResponseStatus.Error,
        //            Message = languageId == Language.english ? "Cant Change to this status Of this Order" : "لا يمكن تغير حالة هذا الطلب"
        //        };
        //    }
        //    if ((vm.StatusId == (int)StatusEnum.CODReceived || vm.StatusId == (int)StatusEnum.CustomerCancelled || vm.StatusId == (int)StatusEnum.FailedFeesCollected) && orders.Any(w => w.DriveryId == null))
        //    {
        //        return new BaseResponse<bool>()
        //        {
        //            Status = ResponseStatus.Error,
        //            Message = languageId == Language.english ? "Cant Change to this status without  chose driver" : "لا يمكن أختيار هذة الحالة بدون اختيار سايق"
        //        };
        //    }
        //    var oederstatuses = await _statusRepository.GetAll();
        //    var clients= await _ClientRepository.FindByCondition(w=> orders.Select(w=>w.ClientId).Distinct().Any(c=>c==w.Id));

        //    foreach (var order in orders)
        //    {
        //        var oldstatus = oederstatuses.FirstOrDefault(w=>w.Id==order.Id);
        //        oldstatus.OrderCount = oldstatus.OrderCount > 0 ? oldstatus.OrderCount - 1 : 0;
        //        order.StatusId = vm.StatusId;
        //        var newStatus = await _statusRepository.GetById(vm.StatusId);
        //        newStatus.OrderCount++;
        //        _orderRepository.Update(order);
        //        _statusRepository.Update(oldstatus);
        //        _statusRepository.Update(newStatus);
        //        OrderHistory hes = new OrderHistory()
        //        {
        //            OrderId = order.Id,
        //            StatusId = vm.StatusId,
        //            UserName = _authService.CurrentUser.UserName
        //        };
        //        await _orderHistoryRepository.Add(hes);
        //        if (order.StatusId == (int)StatusEnum.CODReceived)
        //        {
        //            var client = order.;
        //            client.TotalBalance = client.TotalBalance + order.Amount;
        //            _ClientRepository.Update(client);
        //            var driver = await _employeeRepository.GetById(order.DriveryId.Value);
        //            driver.DefaultFees = driver.DefaultFees + 1;
        //            _employeeRepository.Update(driver);
        //        }
        //        if (order.StatusId == (int)StatusEnum.CustomerCancelled)
        //        {

        //            var client = await _ClientRepository.GetById(order.ClientId);
        //            client.TotalBalance = client.TotalBalance - ((order.MaterialFees ?? 0) + order.DriveryFees + order.OrderFees);
        //            _ClientRepository.Update(client);
        //        }
        //    }

        //    await _unitOfWork.Save();

        //    return new BaseResponse<bool>()
        //    {
        //        Status = ResponseStatus.Success,
        //        Result = true,
        //    };
        //}

        public async Task<BaseResponse<float>> GetOrdersFees(OrdersVM vM, Language languageId)
        {
            var orders = await _orderRepository.FindByCondition(w => vM.OrderIds.Any(o => o == w.Id));


            var isAllowOrderChangeStatus = orders.All(w => (w.StatusId == (int)StatusEnum.CODReceived || w.StatusId == (int)StatusEnum.CustomerCancelled || w.StatusId == (int)StatusEnum.FailedFeesCollected));
            if (!isAllowOrderChangeStatus)
            {
                return new BaseResponse<float>()
                {
                    Message = languageId == Language.english ? "Some Orders Enable TO Change Status" : "Some Orders Enable TO Change Status",
                    Status = ResponseStatus.Error,
                };
            }

            return new BaseResponse<float>()
            {
                Status = ResponseStatus.Success,
                Result = orders.Where(w => w.StatusId == (int)StatusEnum.CODReceived).Sum(w => w.Amount) -
                    orders.Where(w => w.StatusId == (int)StatusEnum.CustomerCancelled).Sum(w => (w.MaterialFees ?? 0) + w.OrderFees + w.DriveryFees),
            };

        }

        public async Task<BaseResponse<float>> PayClientOrders(OrdersVM vm, Language languageId)
        {
            var orders = await _orderRepository.FindByCondition(w => vm.OrderIds.Any(o => o == w.Id), e => e.Include(w => w.Status).Include(w => w.City).Include(w => w.District).Include(w => w.OrderHistories));
            //CreateAndSendExcelFile(orders.ToList(), "ibrahemessam020@gmail.com");
            if (!orders.All(w => (w.StatusId == (int)StatusEnum.CODReceived || w.StatusId == (int)StatusEnum.CustomerCancelled || w.StatusId == (int)StatusEnum.FailedFeesCollected)))
            {
                return new BaseResponse<float>()
                {
                    Message = languageId == Language.english ? "Some Orders Enable TO Change Status" : "Some Orders Enable TO Change Status",
                    Status = ResponseStatus.Error,
                };
            }
            int count = 0;
            foreach (var item in orders)
            {
                if (item.StatusId == (int)StatusEnum.CODReceived)
                {
                    item.StatusId = (int)StatusEnum.Paid;
                    count++;
                    item.OrderHistories.Add(new OrderHistory()
                    {
                        EmployeeId = _authService.CurrentUser?.IsAdmin == true ? _authService.CurrentUser?.UserId : null,
                        UserName = _authService.CurrentUser?.UserName ?? "Admin",
                        StatusId = (int)StatusEnum.Paid
                    });
                }
                else
                {
                    item.DisAllowShowInPayment = true;
                }
                _orderRepository.Update(item);
            }
            var oldstd = await _statusRepository.GetById((int)StatusEnum.CODReceived);
            var oldstatus = oldstd.OrderCount - count;
            oldstd.OrderCount = oldstatus >= 0 ? oldstatus : 0;
            _statusRepository.Update(oldstd);
            var paiedstd = await _statusRepository.GetById((int)StatusEnum.Paid);
            paiedstd.OrderCount = paiedstd.OrderCount + count;
            _statusRepository.Update(paiedstd);

            var client = await _ClientRepository.GetById(orders.FirstOrDefault().ClientId);
            var deductedBalance = orders.Where(w => w.StatusId == (int)StatusEnum.CODReceived).Sum(w => w.Amount) -
                    orders.Where(w => w.StatusId == (int)StatusEnum.CustomerCancelled).Sum(w => (w.MaterialFees ?? 0) + w.OrderFees + w.DriveryFees);
            var balance = client.TotalBalance - deductedBalance;
            client.TotalBalance = balance;
            _ClientRepository.Update(client);

            await _unitOfWork.Save();

            CreateAndSendExcelFile(orders.ToList(), client.Email,deductedBalance);
            return new BaseResponse<float>()
            {
                Status = ResponseStatus.Success,
                Result = orders.Sum(w => w.Amount),
            };
        }

        public async Task<BaseResponse<bool>> EditOrder(UpdateOrderVM vM, Language languageId)
        {

            var order = await _orderRepository.GetById(vM.OrderId);
            if (order == null)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "Not Found" : "غير موجود"

                };
            }
            if (order.StatusId == (int)StatusEnum.CODReceived || order.StatusId == (int)StatusEnum.Delivered || order.StatusId == (int)StatusEnum.Paid)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "Oredr Deleverd" : "Oredr Deleverd"

                };

            }
            //order.DriveryId = vM.DriverId;
            //if (vM.Amount != 0)
            //{
            //    order.OrderFees = vM.Amount;

            //}
            //order.DriveryFees = vM.DriverFees;

            if (order.Weight > 1)
            {
                int weightSalary = int.Parse(_configuration["DefaultWeight"]);
                order.DriveryFees = (vM.Weight - 1) * weightSalary;
            }
            else
            {
                order.DriveryFees = 0;
            }
            order.Weight = vM.Weight;
            order.Address = vM.Address;
            order.MobileNumber = vM.MobileNumber;
            order.Name = vM.Name;
            if (vM.AmountUpdated)
            {
                order.Amount = vM.Amount;

            }
            var city = await _cityRepository.GetById(vM.cityId);
            order.OrderFees = city.Fees;
            //order.MaterialFees = vM.ShipFees;
            order.CityId = vM.cityId;
            order.DistrictId = vM.DistrictId;
            order.Recipient = vM.Recipient;
            order.Description = vM.Description;
            order.OrderTypeId = vM.OrderTypeId;
            _orderRepository.Update(order);
            await _unitOfWork.Save();
            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = true,
            };
        }

        public async Task<BaseResponse<bool>> AssignOrdersToDrive(AssignOrdersToDriveVM vm, Language languageId)
        {
            var orders = await _orderRepository.FindByCondition(w => vm.OrderIds.Any(o => o == w.Id));

            foreach (var item in orders)
            {
                item.DriveryId = vm.DriverId;
                _orderRepository.Update(item);
            }
            await _unitOfWork.Save();
            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = true,
            };

        }

        public async Task<BaseResponse<bool>> AddOrderFromExcel(AddOrdersFromExcelvm vm, Language languageId)
        {
            if (vm.File == null || vm.File.Length == 0)
            {
                return new BaseResponse<bool>();
            }
            var errors = new List<string>();

            var cities = await _cityRepository.GetAll();
            var districts = await _districtRepository.GetAll();
            var orderTypes = await _orderTypeRepository.GetAll();

            using (var stream = new MemoryStream())
            {
                await vm.File.CopyToAsync(stream);
                stream.Position = 0;

                // Load Excel file using Spire.Xls
                Workbook workbook = new Workbook();
                workbook.LoadFromStream(stream);
                Worksheet worksheet = workbook.Worksheets[0]; // Assuming the first worksheet
                Console.WriteLine(worksheet.LastRow);
                for (int rowIndex = 2; rowIndex <= worksheet.LastRow; rowIndex++) // Skip header row
                {
                    try
                    {
                        var row = worksheet.Rows[rowIndex - 1]; // Get the current row
                        if (!row.IsBlank)
                        {
                            if (!string.IsNullOrEmpty(row.Cells[0].Value)&&!string.IsNullOrEmpty(row.Cells[1].Value)&& !string.IsNullOrEmpty(row.Cells[5].Value))
                            {

                            
                            var addOrderVM = new AddOrderVM
                            {
                                Name = string.IsNullOrEmpty(row.Cells[0].Value) ? null : row.Cells[0].Value, // Name
                                MobileNumber = string.IsNullOrEmpty(row.Cells[1].Value) ? null : row.Cells[1].Value, // Mobile Number
                                Address = string.IsNullOrEmpty(row.Cells[2].Value) ? null : row.Cells[2].Value, // Address
                                Description = string.IsNullOrEmpty(row.Cells[3].Value) ? null : row.Cells[3].Value, // Description
                                Weight = string.IsNullOrEmpty(row.Cells[4].Value) ? 1 : int.Parse(row.Cells[4].Value), // Weight
                                Amount = string.IsNullOrEmpty(row.Cells[5].Value) ? 1 : int.Parse(row.Cells[5].Value), // Amount
                                CityId = cities.FirstOrDefault(w => w.Name.ToLower() == row.Cells[6].Value.Trim().ToLower())?.Id ?? cities.FirstOrDefault().Id, // City Name
                                DistrictId = string.IsNullOrEmpty(row.Cells[7].Value) ? null : districts.FirstOrDefault(w => w.NameAr.ToLower() == row.Cells[7].Value.Trim().ToLower())?.Id, // District Id
                                OrderTypeId = string.IsNullOrEmpty(row.Cells[8].Value) ? null : orderTypes.FirstOrDefault(w => w.Name.ToLower() == row.Cells[8].Value.Trim().ToLower())?.Id, // Order Type Id
                                ClientId = vm.ClientId, // Client Id,
                                MaterialIds = new List<int>()
                            };

                            var response = await AddOrder(addOrderVM);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return new BaseResponse<bool>()
                        {
                            Status = ResponseStatus.Error,
                            Message = ex.Message,
                        };
                    }
                }
            }

            return new BaseResponse<bool>()
            {
                Status = ResponseStatus.Success,
                Result = true,
            };
        }
        public void CreateAndSendExcelFile(List<Order> orders, string clientMail,float deductedBalance)
        {
            try
            {
                SendEmailWithAttachment(orders, clientMail, deductedBalance);

            }
            catch
            {

            }
        }

        public async Task sendmail()
        {
            var orders = await _orderRepository.FindByCondition(w=>w.IsDeleted==true , e => e.Include(w => w.Status).Include(w => w.City).Include(w => w.District).Include(w => w.OrderHistories));

            SendEmailWithAttachment(orders.ToList(), "ibrahemessam11116@gmail.com", 1222);
        }
        public void SendEmailWithAttachment(List<Order> orders, string clientMail,float deductedBalance)
        {
            // Create a new MimeMessage
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("moonlightfaster@gmail.com"));
            email.To.Add(MailboxAddress.Parse(clientMail));

            email.Subject = "Payed Orders";
            var body = new TextPart("plain")
            {
                Text = "Please find the attached Excel file."
            };


            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // Add headers
                worksheet.Cell(1, 1).Value = "Name";
                worksheet.Cell(1, 2).Value = "Recipient";
                worksheet.Cell(1, 3).Value = "MobileNumber";
                worksheet.Cell(1, 4).Value = "Address";
                worksheet.Cell(1, 5).Value = "City";
                worksheet.Cell(1, 6).Value = "Distric";
                worksheet.Cell(1, 7).Value = "Description";
                worksheet.Cell(1, 8).Value = "Fees";
                worksheet.Cell(1, 9).Value = "Amount";
                worksheet.Cell(1, 10).Value = "Status";

                int row = 2;
                foreach (var recipient in orders)
                {
                    worksheet.Cell(row, 1).Value = recipient.Name;
                    worksheet.Cell(row, 2).Value = recipient.Recipient;
                    worksheet.Cell(row, 3).Value = recipient.MobileNumber;
                    worksheet.Cell(row, 4).Value = recipient.Address;
                    worksheet.Cell(row, 5).Value = recipient.City.Name;
                    worksheet.Cell(row, 6).Value = recipient.District?.Name ?? "";
                    worksheet.Cell(row, 7).Value = recipient.Description;
                    worksheet.Cell(row, 8).Value = recipient.OrderFees;
                    worksheet.Cell(row, 9).Value = recipient.Amount;
                    worksheet.Cell(row, 10).Value = recipient.Status.Name ?? "";
                    row++;
                }
                row=row+1;
                worksheet.Cell(row, 1).Value = "Total Payment";
                worksheet.Cell(row, 10).Value = deductedBalance;


                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Seek(0, SeekOrigin.Begin);  // Reset stream position

                    var attachment = new MimePart("application", "vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        Content = new MimeContent(stream, ContentEncoding.Default),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = "PaymentOrders.xlsx"
                    };
                    var multipart = new Multipart("mixed");
                    multipart.Add(body);
                    multipart.Add(attachment);
                    email.Body = multipart;

                    using var smtp = new MailKit.Net.Smtp.SmtpClient();
                    smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    smtp.Authenticate("moonlightfaster@gmail.com", "audk nggi wrsu qaaz");
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }
            }


        }

        public async Task<BaseResponse<bool>> SendDiscount(SendDiscountVM vm, Language languageId)
        {
            var order = await _orderRepository.GetById(vm.OrderId);
            if (order == null)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "order Not Found" : "الطلب  غير موجود "
                };
            }
            if (order.StatusId == (int)StatusEnum.Delivered || order.StatusId == (int)StatusEnum.CODReceived || order.StatusId == (int)StatusEnum.Cancelled || order.StatusId == (int)StatusEnum.NotReceived || order.StatusId == (int)StatusEnum.Paid)
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.english ? "Cant Make Discount For This Order  " : "لا يمكن عمل خصم لهذا الطلب  ",
                };
            }
            var newFees = order.OrderFees - vm.Discount;
            order.OrderFees = newFees > 0 ? newFees : 0;
            _orderRepository.Update(order);
            await _unitOfWork.Save();
            return new BaseResponse<bool> { Status = ResponseStatus.Success, Result = true };
        }

        public async Task<BaseResponse<bool>> RemoveCanceldOrder(int id, Language languageId)
        {
            var order = await _orderRepository.GetById(id);
            if (order == null || order.IsDeleted)
            {

                return new BaseResponse<bool>()
                {
                    Message = languageId == Language.english ? "Order No Found" : "الطلب غير موجود"

                };
            }

            if (order.StatusId != (int)StatusEnum.CustomerCancelled || order.StatusId != (int)StatusEnum.FailedFeesCollected)
            {
                return new BaseResponse<bool>()
                {
                    Message = languageId == Language.english ? "Can`t Remove This Order " : "لا يمكن حذف هذا الطلب"

                };
            }
            order.DisAllowShowInPayment = true;
            return null;
        }
    }
}
