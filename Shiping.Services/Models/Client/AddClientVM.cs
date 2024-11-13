using System.ComponentModel.DataAnnotations;

namespace Shiping.Services.Models.Client
{
    public class AddClientVM
    {
        [Required(ErrorMessage = "CompanyName Is Required")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "PhoneNumber Is Required")]
        [RegularExpression(@"^(01[0-9]{9}|02[0-9]{8})$", ErrorMessage = "Invalid Egyptian phone number format")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "UserName Is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email Is Required")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; }
        [Required]
        public int CityId { get; set; }
        public int? DistrictId { get; set; }
    }
}
