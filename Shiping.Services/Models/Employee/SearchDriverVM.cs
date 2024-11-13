namespace Shiping.Services.Models.Employee
{
    public class SearchDriverVM : PagingVM
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public int? CityId { get; set; }
        public string? Title { get; set; }
    }
}
