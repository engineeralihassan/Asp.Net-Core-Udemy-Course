using Microsoft.AspNetCore.Mvc;

namespace _09_LayoutViews.Controllers
{
    public class productsController1 : Controller
    {
        [Route("products")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("sellers")]
        public IActionResult Sellers()
        {
            return View();
        }
        [Route("orders")]
        public IActionResult Orders()
        {
            return View();
        }
    }
}
