using Microsoft.AspNetCore.Mvc;

namespace _05_Controllers.Controllers
{
    // as simple class body is enough to create a controller
    // if we write the controller with class name its automatically
    // judge this is a controller by system
    public class HomeController
    {
        [Route("home")]
        [Route("/")]
        public string Index() => "Hello from the controller method 1";

        [Route("about")]
        public string About()
        {
            return "WellCome To the About us Page ";
        }

        [Route("contact/{mobile:long}")]
        public string Contact()
        {
            return "WellCome To the Contact us  us Page ";
        }

        // Content type Result
        [Route("reports")]
        public ContentResult ContentResult1()
        {
            return new ContentResult()
            {
                Content = "<h1>This is the Content type result of Html </h1>",
                ContentType = "text/html"
            };
        }
    }
}