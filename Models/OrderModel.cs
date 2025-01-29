using System.ComponentModel.DataAnnotations;

namespace Phinscal.Models
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool CardPayment { get; set; } = false;
        public bool InventoryManagement { get; set; } = false;
        public string? PaymentMethod { get; set; }
        public string DeliveryAddress { get; set; } = "";
        public DateTime DeliveryDate { get; set; } = DateTime.Today + TimeSpan.FromDays(5);
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
