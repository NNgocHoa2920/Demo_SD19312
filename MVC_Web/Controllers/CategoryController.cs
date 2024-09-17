using Microsoft.AspNetCore.Mvc;
using MVC_Web.Models;

namespace MVC_Web.Controllers
{
    public class CategoryController : Controller
    {
        SD19312DbContext _db; // gọi lại db sang controller để sử dụng
        
        public CategoryController(SD19312DbContext db)
        {
            _db = db;
        }
        //action: Index
        public IActionResult Index() //hiển thị toàn bộ dữ liệu của category
        {
            var categoryList = _db.Categories.ToList();
            return View(categoryList); // trả về toàn bộ dữ liệu
        }
        //Thêm 1 đối tượng category
        public IActionResult Create(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("Index"); // sau khi add xong thì se quay về trang index
        }

    }
}
