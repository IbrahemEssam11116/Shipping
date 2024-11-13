using System.ComponentModel.DataAnnotations;

namespace Shiping.Services.Models
{
    public class PagingVM
    {
        [Range(1, int.MaxValue, ErrorMessage = "pageNumber must be greater than 0")]
        public int pageNumber { get; set; } = 1;
        [Range(1, int.MaxValue, ErrorMessage = "pageSize must be greater than 0")]
        public int pageSize { get; set; } = 7;
    }
}
