using System.ComponentModel.DataAnnotations.Schema;

namespace Shiping.Repository.Models
{
    public class Order : BaseModel
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public string MobileNumber { get; set; }
        public string Name { get; set; }
        public string Recipient { get; set; }
        public string Address { get; set; }
        public float OrderFees { get; set; }
        public float DriveryFees { get; set; }
        public float? MaterialFees { get; set; }
        public int? DriveryId { get; set; }
        [ForeignKey("DriveryId")]
        public Employee? Drivery { get; set; }
        //public int? MaterialId { get; set; }
        //public Material? Material { get; set; }
        public List<OrderMaterial> OrderMaterials { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int? DistrictId { get; set; }
        public District? District { get; set; }
        public string Description { get; set; }
        public int? OrderTypeId { get; set; }
        public OrderType OrderType { get; set; }
        public int Weight { get; set; }
        public int Amount { get; set; }
        public bool DisAllowShowInPayment{ get; set; }
        public ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
