using Microsoft.EntityFrameworkCore.Query.Internal;
using PrimeDealsRealestat.Repository.Interfaces;
using Shiping.Repository.Models;
using Shiping.Services.Enum;
using Shiping.Services.Models.Lookupa;
using Shiping.Services.Models.Lookupa.City;
using Shiping.Services.Models.Lookupa.Distincate;
using Shiping.Services.Models.Lookupa.Material;
using Shipping.Models;

namespace Shiping.Services.Services
{
    public class LookupsService
    {
        private readonly IGenericRepository<City> _cityRepository;
        private readonly IGenericRepository<Permissrion> _permissrionRepository;
        private readonly IGenericRepository<EmployeeType> _employeeTypeRepository;
        private readonly IGenericRepository<District> _districtRepository;
        private readonly IGenericRepository<Status> _statusRepository;
        private readonly IGenericRepository<Material> _materialRepository;
        private readonly IGenericRepository<CompanyInfo> _companyInfoRepository;
        private readonly IGenericRepository<OrderType> _orderTypeRepository;
        private readonly IUnitOfWork _unitOfWork;
        public LookupsService(IGenericRepository<City> cityRepository, IGenericRepository<Permissrion> permissrionRepository, IGenericRepository<District> districtRepository, IGenericRepository<EmployeeType> employeeTypeRepository, IGenericRepository<Status> statusRepository, IUnitOfWork unitOfWork, IGenericRepository<Material> materialRepository, IGenericRepository<CompanyInfo> companyInfoRepository, IGenericRepository<OrderType> orderTypeRepository)
        {
            _cityRepository = cityRepository;
            _permissrionRepository = permissrionRepository;
            _districtRepository = districtRepository;
            _employeeTypeRepository = employeeTypeRepository;
            _statusRepository = statusRepository;
            _unitOfWork = unitOfWork;
            _materialRepository = materialRepository;
            _companyInfoRepository = companyInfoRepository;
            _orderTypeRepository = orderTypeRepository;
        }

        public async Task<BaseResponse<List<CityVM>>> GetCity(Language languageId)
        {
            var cities = await _cityRepository.GetAll();
            return new BaseResponse<List<CityVM>>
            {
                Status = ResponseStatus.Success,
                Result = cities.Select(w => new CityVM()
                {
                    Id = w.Id,
                    Name = languageId == Language.english ? w.Name : w.NameAr,
                    Fees = w.Fees,
                    SideFees = w.SideFees,
                }).ToList()
            };
        }

        public async Task<BaseResponse<List<lokkupVM>>> GetPermission(Language languageId)
        {
            var cities = await _permissrionRepository.GetAll();
            return new BaseResponse<List<lokkupVM>>
            {
                Status = ResponseStatus.Success,
                Result = cities.Select(w => new lokkupVM()
                {
                    Id = w.Id,
                    Name = languageId == Language.english ? w.Name : w.NameAr,
                }).ToList()
            };
        }
        public async Task<BaseResponse<List<DistrictVM>>> GetDistrict(int? cityId, Language languageId)
        {
            var cities = await _districtRepository.FindByCondition(w => (cityId == null || cityId == 0 || w.CityId == cityId));
            return new BaseResponse<List<DistrictVM>>
            {
                Status = ResponseStatus.Success,
                Result = cities.Select(w => new DistrictVM()
                {
                    Id = w.Id,
                    Name = w.NameAr,
                    Fees = w.Fees,
                }).ToList()
            };
        }

        public async Task<BaseResponse<List<lokkupVM>>> GetEmployeeTypes(Language languageId)
        {
            var cities = await _employeeTypeRepository.GetAll();
            return new BaseResponse<List<lokkupVM>>
            {
                Status = ResponseStatus.Success,
                Result = cities.Select(w => new lokkupVM()
                {
                    Id = w.Id,
                    Name = languageId == Language.english ? w.Name : w.NameAr,
                }).ToList()
            };
        }
        public async Task<BaseResponse<bool>> AddEmployeeType(AddLoockupVM vM)
        {
            EmployeeType employeeType = new EmployeeType()
            {
                Name = vM.Name,
                NameAr = vM.NameAr,
                IsAllowDelete = true,

            };
            await _employeeTypeRepository.Add(employeeType);
            await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = ResponseStatus.Success,
                Result = true,
            };
        }
        public async Task<BaseResponse<List<lokkupVM>>> GetOrderStatus(Language languageId)
        {
            var cities = await _statusRepository.GetAll();
            return new BaseResponse<List<lokkupVM>>
            {
                Status = ResponseStatus.Success,
                Result = cities.Select(w => new lokkupVM()
                {
                    Id = w.Id,
                    Name = languageId == Language.english ? w.Name : w.NameAr,
                }).ToList()
            };
        }

        public async Task<BaseResponse<bool>> AddCity(AddCityVM vm, Language languageId)
        {
            var cities =await _cityRepository.FindByCondition(w => w.Name.ToLower() == vm.Name.ToLower());
            if (cities.Any())
            {
                return new BaseResponse<bool>()
                {
                    Status = ResponseStatus.Error,
                    Result = false,
                    Message = languageId == Language.english ? "City Exist" : "مدينة موجودة",
                };
            }
            City city = new City()
            {
                Name = vm.Name,
                NameAr = vm.NameAr,
                Fees = vm.Fees,
                SideFees = vm.SideFees,
            };
            await _cityRepository.Add(city);
            var isSaved = await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = isSaved ? ResponseStatus.Success : ResponseStatus.Error,
                Result = isSaved,
            };
        }
        public async Task<BaseResponse<bool>> UpdateCity(UpdateCityVM vm, Language languageId)
        {
            var city = await _cityRepository.GetById(vm.Id);
            if (city == null)
            {
                return new BaseResponse<bool>()
                {
                    Result = false,
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.arabic ? "غير موجود" : "Not Found"
                };
            }

            //city.Name = vm.Name;
            //city.NameAr = vm.NameAr;
            city.Fees = vm.Fees;
            city.SideFees = vm.SideFees;

            _cityRepository.Update(city);
            var isSaved = await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = isSaved ? ResponseStatus.Success : ResponseStatus.Error,
                Result = isSaved,
            };
        }


        public async Task<BaseResponse<bool>> AddDistrict(AddDistrictVM vm, Language languageId)
        {
            District district = new District()
            {
                Name = vm.Name,
                NameAr = vm.NameAr,
                Fees = vm.Fees,
                CityId = vm.CityId,

            };
            await _districtRepository.Add(district);
            var isSaved = await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = isSaved ? ResponseStatus.Success : ResponseStatus.Error,
                Result = isSaved,
            };
        }
        public async Task<BaseResponse<bool>> UpdateDistrict(UpdateDistrictVM vm, Language languageId)
        {
            var district = await _districtRepository.GetById(vm.Id);
            if (district == null)
            {
                return new BaseResponse<bool>()
                {
                    Result = false,
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.arabic ? "غير موجوج" : "Not Found"
                };
            }

            //district.Name = vm.Name;
            //district.NameAr = vm.NameAr;
            district.Fees = vm.Fees;
            district.CityId = vm.CityId;


            _districtRepository.Update(district);
            var isSaved = await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = isSaved ? ResponseStatus.Success : ResponseStatus.Error,
                Result = isSaved,
            };
        }

        public async Task<BaseResponse<List<MaterialVM>>> GetMaterial(Language languageId)
        {
            var cities = await _materialRepository.GetAll();
            return new BaseResponse<List<MaterialVM>>
            {
                Status = ResponseStatus.Success,
                Result = cities.Select(w => new MaterialVM()
                {
                    Id = w.Id,
                    Name = languageId == Language.english ? w.Name : w.NameAr,
                    Price = w.Price,
                }).ToList()
            };
        }

        public async Task<BaseResponse<bool>> UpdateMaterial(UpdateMaterialVM vm, Language languageId)
        {
            var material = await _materialRepository.GetById(vm.Id);
            if (material == null)
            {
                return new BaseResponse<bool>()
                {
                    Result = false,
                    Status = ResponseStatus.Error,
                    Message = languageId == Language.arabic ? "غير موجوج" : "Not Found"
                };
            }

            //material.Name = vm.Name;
            //material.NameAr = vm.NameAr;
            material.Price = vm.Price;


            _materialRepository.Update(material);
            var isSaved = await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = isSaved ? ResponseStatus.Success : ResponseStatus.Error,
                Result = isSaved,
            };
        }
        public async Task<BaseResponse<bool>> AddMaterial(AddMaterialVM vm, Language languageId)
        {
            Material material = new Material()
            {
                Name = vm.Name,
                NameAr = vm.NameAr,
                Price = vm.Price,


            };
            await _materialRepository.Add(material);
            var isSaved = await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = isSaved ? ResponseStatus.Success : ResponseStatus.Error,
                Result = isSaved,
            };
        }

        public async Task<CompanyInfo> GetCompanyInfo()
        {
            var info = await _companyInfoRepository.GetAll();
            return info.FirstOrDefault();
        }

        public async Task<BaseResponse<bool>> UpdateAboutUs(UpdateAboutUsVM vm)
        {
          var info=  await GetCompanyInfo();
            if (info == null)
            {
                info = new CompanyInfo();
                info.AboutUsAR = vm.AboutUsAr;
                info.AboutUs = vm.AboutUs;
                vm.PhoneNumber = vm.PhoneNumber;
                await _companyInfoRepository.Add(info);
            }
            else
            {
                info.AboutUsAR = vm.AboutUsAr;
                info.AboutUs = vm.AboutUs;
                vm.PhoneNumber = vm.PhoneNumber;
                _companyInfoRepository.Update(info);
            }
     
            await _unitOfWork.Save();
            return new BaseResponse<bool>()
            {
                Status= ResponseStatus.Success,
                Result = true,
            };
        }

        public async Task<BaseResponse<List<lokkupVM>>> GetOrderType(Language languageId)
        {
            var cities = await _orderTypeRepository.GetAll();
            return new BaseResponse<List<lokkupVM>>
            {
                Status = ResponseStatus.Success,
                Result = cities.Select(w => new lokkupVM()
                {
                    Id = w.Id,
                    Name = languageId == Language.english ? w.Name : w.NameAr,
               
                }).ToList()
            };
        }
        public async Task<BaseResponse<bool>> AddOrderType(AddLoockupVM vm, Language languageId)
        {
            OrderType material = new OrderType()
            {
                Name = vm.Name,
                NameAr = vm.NameAr,


            };
            await _orderTypeRepository.Add(material);
            var isSaved = await _unitOfWork.Save();
            return new BaseResponse<bool>
            {
                Status = isSaved ? ResponseStatus.Success : ResponseStatus.Error,
                Result = isSaved,
            };
        }
        //public async Task<BaseResponse<bool>> UpdateOrderType(UpdateLoockupVM vm, Language languageId)
        //{
        //    var material = await _orderTypeRepository.GetById(vm.Id);
        //    if (material == null)
        //    {
        //        return new BaseResponse<bool>()
        //        {
        //            Result = false,
        //            Status = ResponseStatus.Error,
        //            Message = languageId == Language.arabic ? "غير موجوج" : "Not Found"
        //        };
        //    }

        //    material.Name = vm.Name;
        //    //material.NameAr = vm.NameAr;


        //    _orderTypeRepository.Update(material);
        //    var isSaved = await _unitOfWork.Save();
        //    return new BaseResponse<bool>
        //    {
        //        Status = isSaved ? ResponseStatus.Success : ResponseStatus.Error,
        //        Result = isSaved,
        //    };
        //}

    }
}
