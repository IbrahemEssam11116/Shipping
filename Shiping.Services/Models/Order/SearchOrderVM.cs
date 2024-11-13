namespace Shiping.Services.Models.Order
{
    public class SearchOrderVM : PagingVM
    {
        public DateTime? Day { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public int? DriverId { get; set; }
        public int? ClietId { get; set; }
        public int? StatusId { get; set; }
        public List<int> OrderCodes { get; set; }
        public string? MobileNumber { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
    }
}
