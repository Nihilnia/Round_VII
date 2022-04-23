using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace idk.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 99, ErrorMessage = "Numbers must be between 1- 99")]
        public int DisplayOrder { get; set; }

        [DisplayName("Created Date- Time")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
