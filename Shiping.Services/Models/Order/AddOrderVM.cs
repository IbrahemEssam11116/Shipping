using System.ComponentModel.DataAnnotations;

namespace Shiping.Services.Models.Order
{
    public class AddOrderVM
    {
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int CityId { get; set; }

        public int? DistrictId { get; set; }
        public string Description { get; set; }

        public int? ClientId { get; set; }
        [Required]
        public string Name { get; set; }

        public int Weight { get; set; } = 1;
        public int Amount { get; set; }
        public int? OrderTypeId { get; set; }

        public List<int> MaterialIds { get; set; }

    }
}
