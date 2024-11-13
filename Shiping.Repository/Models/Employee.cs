namespace Shiping.Repository.Models
{
    public class Employee : BaseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public string title { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int? DistrictId { get; set; }
        public float? DefaultFees { get; set; }
        public District? District { get; set; }
        public string? Address { get; set; }
        public string? FCMToken { get; set; }
        public ICollection<EmployeePermission> EmployeePermissions { get; set; }
        public ICollection<OrderHistory> OrderHistories { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}
