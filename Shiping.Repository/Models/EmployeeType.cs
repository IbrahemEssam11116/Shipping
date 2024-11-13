namespace Shiping.Repository.Models
{
    public class EmployeeType : BaseModel
    {
        public string Name { get; set; }
        public string NameAr { get; set; }
        public bool IsAllowDelete { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
