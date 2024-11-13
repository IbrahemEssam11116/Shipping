namespace Shiping.Repository.Models
{
    public class District : BaseModel
    {
        public string Name { get; set; }
        public string NameAr { get; set; }
        public int CityId { get; set; }
        public float Fees { get; set; } = 0;
        public City City { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
