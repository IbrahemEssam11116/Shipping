using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Employee
{

    public class ClientCODVM
    {
        public int TotalCODItem { get; set; }
        public int TotalCODAmount { get; set; }
    }
        public class DashBoardViewModel
    {
        public List<DashBordVM> StatusSummaries { get; set; }
        public ClientCODVM ClientCOD { get; set; }

    }
}
