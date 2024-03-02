using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage ="Максимальная длинна название не должна привышать 30 символов")]
        [DisplayName("Название категории")]
        public string Name { get; set; }
        [DisplayName("Порядок отображения")]
        [Range(1,100, ErrorMessage ="Диапозон значени должен быть между 1 и 100")]
        public int DisplayOrder { get; set; }
    }
}
