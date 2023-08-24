using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fruit.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string type { get; set; }
        public string origin { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
        public int stocklevel { get; set; }
        public string image { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int InventoryId { get; set; }
        public Inventory inventory { get; set; }
    }
}
