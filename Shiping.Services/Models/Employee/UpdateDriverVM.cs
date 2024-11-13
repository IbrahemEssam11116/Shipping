using System.ComponentModel.DataAnnotations;

namespace Shiping.Services.Models.Employee
{
    public class UpdateDriverVM
    {
        [Required]
        public int Id { get; set; }
        public int CityId { get; set; }
        public int? DistrictId { get; set; }
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? title { get; set; }
        public string? Email { get; set; }
        public List<int>? Permissions { get; set; }
    }
}
