namespace Shiping.Repository.Models
{
    public class Permissrion : BaseModel
    {
        public string Name { get; set; }
        public string NameAr { get; set; }
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public ICollection<EmployeeType> EmployeeTypes { get; set; }
        public ICollection<EmployeePermission> employeePermissions { get; set; }

    }
}
