using Microsoft.AspNetCore.Mvc;

namespace Ecomm_b5.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
