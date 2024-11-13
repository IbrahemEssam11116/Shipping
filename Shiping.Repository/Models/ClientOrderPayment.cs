namespace Shiping.Repository.Models
{
    public class ClientOrderPayment : BaseModel
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public float Amount { get; set; }

    }
}
