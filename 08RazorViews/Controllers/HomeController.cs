using _08RazorViews.Models;
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
            return View(); // by defuault Views/Home/index.cshtml

        }
        [Route("persons")]
        public IActionResult PersonsLink()
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "Ali Hassan",
                Description = $"This shop is property of the Ali Hassan",
                Age = 21
            };
            Shop shop = new Shop()
            {
                Id = 1,
                Name = "Bismillar kirtyana stro",
                Description = "This is the kiryana store ",

            };
            WrapperModel Wrapper = new WrapperModel()
            {
                shopproperty = shop,
                personproperty = person

            };
            return View("persons", Wrapper);

        }
        [Route("homaslam")]
        public IActionResult Items()
        {
            return View();
        }
    }
}