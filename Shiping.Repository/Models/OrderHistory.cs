namespace Shiping.Repository.Models
{
    public class OrderHistory : BaseModel
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public string? UserName{ get; set; }

    }
}
