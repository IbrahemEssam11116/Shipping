using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Order
{
    public class ChangeOrderFeesVM
    {
        public int OrderId { get; set; }
        public float Fees { get; set; } 
    }
}
