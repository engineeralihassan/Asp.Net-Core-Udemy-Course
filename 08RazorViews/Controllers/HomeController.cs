using Microsoft.AspNetCore.Mvc;

namespace _08RazorViews.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("home")]
        public IActionResult Index()
        {
            string name = "Ali Hassan";
            // ViewData["name"] = "View Data In Asp.net core Mvc";
            return View(name); // by defuault Views/Home/index.cshtml
        }
    }
}
