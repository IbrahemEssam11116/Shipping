using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Order
{
    public class GetPaymentOrderVM
    {
        public DateTime? Day { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public int? DriverId { get; set; }
        public int? ClietId { get; set; }
        public int? OrderCode { get; set; }
    }
}
