namespace Shiping.Repository.Models
{
    public class OrderType:BaseModel
    {
        public string Name { get; set; }
        public string NameAr { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}