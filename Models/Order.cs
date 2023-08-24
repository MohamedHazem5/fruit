using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fruit.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string status { get; set; }
        [Required]
        [MaxLength(100)]
        public string Customer_name { get; set; }
        public int date { get; set; }
        public string shippingaddress { get; set; }
        public string itemspurchased { get; set; }
        public int quantities { get; set; }
        public int total { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
