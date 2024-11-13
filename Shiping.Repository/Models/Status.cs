namespace Shiping.Repository.Models
{
    public class Status : BaseModel
    {
        public string Name { get; set; }
        public string NameAr { get; set; }
        public int OrderCount { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<OrderHistory> OrderHistories { get; set; }

    }
}
