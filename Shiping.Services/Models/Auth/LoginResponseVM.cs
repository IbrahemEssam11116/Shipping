using Shiping.Services.Models.Client;
using Shiping.Services.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Auth
{
    public class LoginResponseVM
    {
        public string Token { get; set; }
        public bool IsEmployee { get; set; }
        public List<string> Permissions{ get; set; }
        public EmployeeVM Employee { get; set; }
        public ClientVM Client{ get; set; }
    }
}
