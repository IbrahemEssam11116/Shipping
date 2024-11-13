namespace Shiping.Services.Models.Order
{
    public class OrderDetailsvm : OrderVM
    {
        public List<OrderHistoryVM> OrderHistories { get; set; }
    }
    public class OrderHistoryVM
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string? UserName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
