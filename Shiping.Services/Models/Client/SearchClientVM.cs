namespace Shiping.Services.Models.Client
{
    public class SearchClientVM : PagingVM
    {
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? CompanyName { get; set; }
    }
}
