using System.ComponentModel.DataAnnotations;

namespace _1_warmUp.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
