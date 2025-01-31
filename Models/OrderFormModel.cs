using System.ComponentModel.DataAnnotations;

namespace Phinscal.Models
{
    public class OrderFormModel
    {
        [Required(ErrorMessage = "Adresa dostave je obavezna.")]
        public string? DeliveryAddress { get; set; }

        [Required(ErrorMessage = "Molimo izaberite datum dostave.")]
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; } = DateTime.Today + TimeSpan.FromDays(5);

        public string? PaymentMethod { get; set; } = "cash";

        public bool CardPayment { get; set; }
        public bool InventoryManagement { get; set; }
    }
}
