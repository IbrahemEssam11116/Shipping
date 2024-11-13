namespace Shiping.Services.Models.Employee
{
    public class AddEmployeeVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int EmployeeTypeId { get; set; }
        public string title { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }
        public int? DistrictId { get; set; }


    }
}
