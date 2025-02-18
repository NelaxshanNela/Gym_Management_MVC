using GymManagementSystem_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymManagementSystem_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Dumbbells", Price = 5000 },
            new Product { Id = 2, Name = "Treadmill", Price = 30000 }
        };
            return View(products);
        }
    }
}
