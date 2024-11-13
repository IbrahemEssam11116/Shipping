using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Employee
{
    public class OrderStatusCountVM
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public int Count { get; set; }
    }
}
