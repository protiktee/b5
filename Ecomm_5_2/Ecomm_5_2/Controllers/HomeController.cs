using System.Diagnostics;
using Ecomm_5_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm_5_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        /// <summary>
        /// http://localhost:56910/Home/Products
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        public JsonResult GetProducts()
        {
            var product = new
            {
                Category = "Smartphone",
                Title = "Samsung",
                Description = "Samsung description"
            };

            List<object> lstproduct = new List<object>();
            lstproduct.Add(product);
            lstproduct.Add(product);
            return Json(lstproduct);
        }
        public JsonResult GetSingleProduct(int ProductID)
        {
            Product product = new Product();
            product.id = 1;
            product.title = "Essence Mascara Lash Princess";
            product.price = 9.99;

            List<string> ListTag = new List<string>();
            ListTag.Add("beauty");
            ListTag.Add("mascara");
            product.tags = ListTag;

            product.dimensions.width = 15.14;
            product.dimensions.height = 13.08;
            product.dimensions.depth    = 22.99;


            Review review = new Review();
            review.rating = 2;
            review.comment = "Would not recommend!2";
            review.date = DateTime.Now.Date;
            review.reviewerName = "Eleanor Collins2";
            review.reviewerEmail = "eleanor.collins@x.dummyjson.com2";
            product.reviews.Add(review);
            review = new Review();
            review.rating = 3;
            review.comment = "Would not recommend!3";
            review.date = DateTime.Now.Date;
            review.reviewerName = "Eleanor Collins3";
            review.reviewerEmail = "eleanor.collins@x.dummyjson.com";
            product.reviews.Add(review);
            review = new Review();
            review.rating = 4;
            review.comment = "Would not recommend!4";
            review.date = DateTime.Now.Date;
            review.reviewerName = "Eleanor Collins4";
            review.reviewerEmail = "eleanor.collins@x.dummyjson.com4";
            product.reviews.Add(review);

            return Json(product);
        }
        //domain/controller/SaveProduct
        [HttpPost]
        public JsonResult SaveProduct([FromBody]Product product)
        { 
            return Json(product);
        }
    }
}
