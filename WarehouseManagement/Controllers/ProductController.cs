using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseManagement.Models;
using WarehouseManagement.WarehouseContext;

namespace WarehouseManagement.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        [HttpGet]
        public IActionResult Index()
        {
            var _product = db.Products.Include(p => p.Category);
            return View(_product);
        }
    }
}
