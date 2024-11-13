using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Lookupa.City
{
    public class AddCityVM : AddLoockupVM
    {
        public int Fees { get; set; }
        public int? SideFees { get; set; }
    }
}
