using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fruit.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string Status { get; set; }
        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }
        public string ShippingAddress { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
