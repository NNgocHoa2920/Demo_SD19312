using System.ComponentModel.DataAnnotations;

namespace MVC_Web.Models
{
    public class Category
    {
        [Key] 
        public int CategoryID { get; set; } // nếu khai báo thuộc tính là id thì vs nó sẽ tự hiểu đây là khóa chính
        [Required] // bắt buộc phải nhập
        [MinLength(2)] // ít nhất 2 kí tự
        public string Name { get; set; }
        [Range(1,100, ErrorMessage ="Displayorder ít nhất là 1 kí tự và nhiều nhất là 100")]
        public int DisplayOrder {  get; set; }
    }
}
