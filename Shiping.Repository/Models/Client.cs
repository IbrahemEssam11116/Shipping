namespace Shiping.Repository.Models
{
    public class Client : BaseModel
    {
        public string CompanyName { get; set; }
        public float TotalBalance { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int? DistrictId { get; set; }
        public District? District { get; set; }

        public ICollection<ClientPayment> ClientPayment { get; set; }
        public ICollection<ClientOrderPayment> ClientOrderPayments { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
