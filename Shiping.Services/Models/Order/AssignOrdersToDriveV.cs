using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Order
{
    public class AssignOrdersToDriveVM
    {
        public List<int> OrderIds { get; set; }
        public int DriverId { get; set; }
    }
}
