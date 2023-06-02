using Microsoft.AspNetCore.Mvc;

namespace _08RazorViews.Controllers
{
    public class productsController : Controller
    {
        [Route("all-products")]
        public IActionResult All()
        {
            return View();
        }
        [Route("aslam")]
        public IActionResult Items()
        {
            return View();
        }
    }
}
