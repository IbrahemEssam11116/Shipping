namespace Shiping.Repository.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            if (Id == 0)
            {
                CreatedAt = DateTime.Now.AddHours(10);
            }
            ModifiedAt = DateTime.Now.AddHours(10);
        }
        public int Id { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
