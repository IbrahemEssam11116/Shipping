using System.ComponentModel.DataAnnotations;

namespace Shiping.Services.Models.Client
{
    public class ApproveRejectClientVM
    {
        [Required]
        public List<int> ClientIds { get; set; } = new List<int>();
        public bool Status { get; set; }
    }
}
