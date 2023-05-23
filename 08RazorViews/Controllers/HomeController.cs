using Microsoft.AspNetCore.Mvc;

namespace _08RazorViews.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("home")]
        public IActionResult Index()
        {
            return View(); // by defuault Views/Home/index.cshtml
        }
    }
}
