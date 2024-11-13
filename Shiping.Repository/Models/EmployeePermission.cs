namespace Shiping.Repository.Models
{
    public class EmployeePermission : BaseModel
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int permissrionId { get; set; }
        public Permissrion permissrion { get; set; }
    }
}
