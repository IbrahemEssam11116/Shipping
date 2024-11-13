namespace Shiping.Services.Models.Client
{
    public class ClientVM
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public int cityId { get; set; }
        public string CityName { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string Email { get; set; }
        public float Balance{ get; set; }
        public string Address { get; set; }

    }
}
