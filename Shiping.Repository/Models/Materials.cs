namespace Shiping.Repository.Models
{
    public class Material : BaseModel
    {
        public string Name { get; set; }
        public string NameAr { get; set; }
        public float Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
