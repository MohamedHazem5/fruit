using System.ComponentModel.DataAnnotations;

namespace fruit.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string stock { get; set; }
    }
}
