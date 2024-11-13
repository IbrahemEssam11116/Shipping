using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Order
{
    public class UpdateOrderVM
    {
        public int OrderId { get; set; }
        public int? DriverId { get; set; }
        public string Address { get; set; }
        public int Amount { get; set; }
        public int Weight { get; set; } = 1;
        public string MobileNumber { get; set; }
        public string Name { get; set; }
        public int cityId{ get; set; }
        public int? DistrictId { get; set; }
        public string? Recipient { get; set; }
        public string Description { get;  set; }
        public int? OrderTypeId { get; set; }
        public bool AmountUpdated { get; set; }=false;

    }
}
