using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiping.Services.Models.Order
{
    public class AddOrdersFromExcelvm
    {
        public IFormFile File { get; set; }
        [Required]
        public int ClientId{ get; set; }
    }
}
