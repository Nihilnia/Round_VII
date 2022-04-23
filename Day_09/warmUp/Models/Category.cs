using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace warmUp.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 99, ErrorMessage = "You can put a number only between 1- 99")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
