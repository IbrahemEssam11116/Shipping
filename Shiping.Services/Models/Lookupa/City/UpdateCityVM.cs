using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Lookupa.City
{
    public class UpdateCityVM : UpdateLoockupVM
    {
        public int Fees { get; set; }
        public int? SideFees { get; set; }
    }
}
