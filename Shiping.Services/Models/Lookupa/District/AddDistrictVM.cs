using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Lookupa.City
{
    public class AddDistrictVM:AddLoockupVM
    {
        public int Fees { get; set; }
        public int CityId{ get; set; }
    }
}
