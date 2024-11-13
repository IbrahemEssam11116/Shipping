namespace Shiping.Repository.Models
{
    public class City : BaseModel
    {
        public string Name { get; set; }
        public string NameAr { get; set; }
        public float Fees { get; set; } = 0;
        public float? SideFees { get; set; }

        public ICollection<District> Districts { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
