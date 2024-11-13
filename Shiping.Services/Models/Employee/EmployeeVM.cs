    namespace Shiping.Services.Models.Employee
{
    public class EmployeePermissionVM
    {
        public int Id { get; set; }
        public string PermissionName { get; set; }
    }
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int EmployeeTypeId { get; set; }
        public string EmployeeType { get; set; }
        public string title { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public int OrdersDeliveredCount { get; set; }
        public ICollection<EmployeePermissionVM> EmployeePermissions { get; set; }
        public List<OrderStatusCountVM> OrdersByStatus { get; set; }


    }
}
