using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Lookupa
{
    public class AddLoockupVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string NameAr { get; set; }

    }
}
