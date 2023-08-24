using System.ComponentModel.DataAnnotations;

namespace fruit.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string adderss { get; set; }
    }
}
