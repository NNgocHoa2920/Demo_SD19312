using Microsoft.AspNetCore.Mvc;
using MVC_Web.Models;

namespace MVC_Web.Controllers
{
    public class CategoryController : Controller
    {
        SD19312DbContext _db; // gọi lại db để sử dụng trong controller
        //Tiêm db vào trong controller => DI
        public CategoryController(SD19312DbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var categoryList = _db.Categories.ToList();
            return View(categoryList);
        }
    }
}
