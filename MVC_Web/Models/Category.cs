using System.ComponentModel.DataAnnotations;

namespace MVC_Web.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage ="Nhập trong khoảng từ 1-100")]
        public int DisplayOrder {  get; set; }
    }
}
