using Microsoft.AspNetCore.Mvc;

namespace ProyectoAPI.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
