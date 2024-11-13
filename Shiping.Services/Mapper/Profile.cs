using AutoMapper;
using PrimeDealsRealestat.Repository.Data;
using Shiping.Repository.Models;
using Shiping.Services.Enum;
using Shiping.Services.Models.Client;
using Shiping.Services.Models.Employee;
using Shiping.Services.Models.Order;

namespace Shiping.Services.Mapper
{
    public class PaginatedListConverter<TSource, TDestination> : ITypeConverter<PaginatedList<TSource>, PaginatedList<TDestination>>
    {
        public PaginatedList<TDestination> Convert(PaginatedList<TSource> source, PaginatedList<TDestination> destination, ResolutionContext context)
        {
            var mappedItems = context.Mapper.Map<List<TDestination>>(source.Data);
            return new PaginatedList<TDestination>()
            {
                Data = mappedItems,
                PageIndex = source.PageIndex,
                TotalCount = source.TotalCount,
                TotalPages = source.TotalPages,

            };
        }
    }
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, AddClientVM>().ReverseMap();
            CreateMap<Order, AddOrderVM>().ReverseMap();
            CreateMap(typeof(PaginatedList<>), typeof(PaginatedList<>))
            .ConvertUsing(typeof(PaginatedListConverter<,>));
            CreateMap<Order, OrderVM>()
            .ForMember(dest => dest.ClientName, opt => opt.MapFrom((src, dest, destMember, context) =>
                (int)context.Items["LanguageId"] == (int)Language.english ? src.Client.CompanyName : src.Client.CompanyName))
            .ForMember(dest => dest.Amount, opt => opt.MapFrom((src, dest, destMember, context) =>
                src.StatusId == (int)StatusEnum.CODReceived ? src.Amount : src.Amount + src.OrderFees + src.DriveryFees + (src.MaterialFees ?? 0)))
            .ForMember(dest => dest.StatusName, opt => opt.MapFrom((src, dest, destMember, context) =>
                (int)context.Items["LanguageId"] == (int)Language.english ? src.Status.Name : src.Status.NameAr))
            .ForMember(dest => dest.DriveryName, opt => opt.MapFrom((src, dest, destMember, context) =>
                src.Drivery != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.Drivery.UserName : src.Drivery.UserName) : null))
            .ForMember(dest => dest.CityName, opt => opt.MapFrom((src, dest, destMember, context) =>
                (int)context.Items["LanguageId"] == (int)Language.english ? src.City.Name : src.City.NameAr))
            .ForMember(dest => dest.OrderTypeName, opt => opt.MapFrom((src, dest, destMember, context) =>
                  src.OrderType != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.OrderType.Name : src.OrderType.NameAr) : null))
            .ForMember(dest => dest.DistrictName, opt => opt.MapFrom((src, dest, destMember, context) =>
                src.District != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.District.Name : src.District.NameAr) : null))
             .ForMember(des => des.createdAt, opt => opt.MapFrom(src => src.CreatedAt))
             .ForMember(des => des.lastModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
             .ForMember(dest => dest.MaterialIds, opt => opt.MapFrom((src, dest, destMember, context) =>
                src.OrderMaterials?.Select(w => w.MaterialId).ToList()));

            CreateMap<AddEmployeeVM, Employee>();
            CreateMap<Employee, EmployeeVM>()
            .ForMember(dest => dest.CityName, opt => opt.MapFrom((src, dest, destMember, context) =>
                (int)context.Items["LanguageId"] == (int)Language.english ? src.City.Name : src.City.NameAr))
            .ForMember(dest => dest.DistrictName, opt => opt.MapFrom((src, dest, destMember, context) =>
                src.District != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.District.Name : src.District.NameAr) : null))
                 .ForMember(des => des.EmployeePermissions, opt => opt.MapFrom(src => src.EmployeePermissions));

            CreateMap<EmployeePermission, EmployeePermissionVM>()
                .ForMember(des => des.Id, opt => opt.MapFrom(src => src.permissrionId))
                .ForMember(dest => dest.PermissionName, opt => opt.MapFrom((src, dest, destMember, context) =>
                     src.permissrion != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.permissrion?.Name : src.permissrion?.NameAr) : null));

            CreateMap<Client, ClientVM>()
           .ForMember(des => des.Balance, opt => opt.MapFrom(src => src.TotalBalance))
           .ForMember(dest => dest.DistrictName, opt => opt.MapFrom((src, dest, destMember, context) =>
               src.City != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.City.Name : src.City.NameAr) : null))
           .ForMember(dest => dest.DistrictName, opt => opt.MapFrom((src, dest, destMember, context) =>
               src.District != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.District.Name : src.District.NameAr) : null));


            CreateMap<Order, OrderDetailsvm>()
            .ForMember(dest => dest.Amount, opt => opt.MapFrom((src, dest, destMember, context) =>
                src.StatusId == (int)StatusEnum.CODReceived ? src.Amount : src.Amount + src.OrderFees + src.DriveryFees + src.MaterialFees ?? 0))
            .ForMember(dest => dest.MaterialIds, opt => opt.MapFrom((src, dest, destMember, context) =>
                src.OrderMaterials?.Select(w => w.MaterialId).ToList()))
           .ForMember(dest => dest.ClientName, opt => opt.MapFrom((src, dest, destMember, context) =>
               (int)context.Items["LanguageId"] == (int)Language.english ? src.Client.CompanyName : src.Client.CompanyName))
           .ForMember(dest => dest.StatusName, opt => opt.MapFrom((src, dest, destMember, context) =>
               (int)context.Items["LanguageId"] == (int)Language.english ? src.Status.Name : src.Status.NameAr))
           .ForMember(dest => dest.DriveryName, opt => opt.MapFrom((src, dest, destMember, context) =>
               src.Drivery != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.Drivery.UserName : src.Drivery.UserName) : null))
           .ForMember(dest => dest.CityName, opt => opt.MapFrom((src, dest, destMember, context) =>
               (int)context.Items["LanguageId"] == (int)Language.english ? src.City.Name : src.City.NameAr))
           .ForMember(dest => dest.DistrictName, opt => opt.MapFrom((src, dest, destMember, context) =>
               src.District != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.District.Name : src.District.NameAr) : null))
           .ForMember(dest => dest.OrderTypeName, opt => opt.MapFrom((src, dest, destMember, context) =>
               src.OrderType != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.OrderType.Name : src.OrderType.NameAr) : null))
           .ForMember(des => des.createdAt, opt => opt.MapFrom(src => src.CreatedAt))
           .ForMember(des => des.lastModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt));

            CreateMap<AddEmployeeVM, Employee>();

            CreateMap<Employee, EmployeeVM>()
            .ForMember(dest => dest.CityName, opt => opt.MapFrom((src, dest, destMember, context) =>
                (int)context.Items["LanguageId"] == (int)Language.english ? src.City.Name : src.City.NameAr))
            .ForMember(dest => dest.DistrictName, opt => opt.MapFrom((src, dest, destMember, context) =>
                src.District != null ? ((int)context.Items["LanguageId"] == (int)Language.english ? src.District.Name : src.District.NameAr) : null))
                 .ForMember(des => des.EmployeePermissions, opt => opt.MapFrom(src => src.EmployeePermissions));

            CreateMap<OrderHistory, OrderHistoryVM>()
                .ForMember(dest => dest.StatusName, opt => opt.MapFrom((src, dest, destMember, context) =>
               (int)context.Items["LanguageId"] == (int)Language.english ? src.Status.Name : src.Status.NameAr));


        }

    }
}
