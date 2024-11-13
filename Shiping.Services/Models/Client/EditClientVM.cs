using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Client
{
    public class EditClientVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "CompanyName Is Required")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "PhoneNumber Is Required")]
        [RegularExpression(@"^(01[0-9]{9}|02[0-9]{8})$", ErrorMessage = "Invalid Egyptian phone number format")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email Is Required")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        public string Address { get; set; }
        [Required]
        public int CityId { get; set; }
        public int? DistrictId { get; set; }
    }
}
