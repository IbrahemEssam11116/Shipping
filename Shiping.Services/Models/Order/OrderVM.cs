using Shiping.Services.Models.Lookupa;

namespace Shiping.Services.Models.Order
{
    public class OrderVM
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string MobileNumber { get; set; }
        public string Name { get; set; }
        public string Recipient { get; set; }
        public string Address { get; set; }
        //public float OrderFees { get; set; }
        //public float DriveryFees { get; set; }
        //public float? MaterialFees { get; set; }
        public List<int> MaterialIds { get; set; }
        public int? DriveryId { get; set; }
        public string DriveryName { get; set; }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string Description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? lastModifiedAt { get; set; }
        public int Amount { get; set; }
        public List<lokkupVM>  AvailableStatus{ get; set; }
        public int? OrderTypeId { get; set; }
        public int Weight { get; set; }

        public string OrderTypeName { get; set; }
    }
}
