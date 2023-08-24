using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fruit.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string message { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
