using Microsoft.AspNetCore.Mvc;

namespace _05_Controllers.Controllers
{
    [Controller]
    public class IActionResultController : Controller
    {
        [Route("book")]
        public IActionResult Index()
        {
            // Status Code Results 

            if (!Request.Query.ContainsKey("id"))
            {

                return BadRequest("<h1>The Id is Not privided </h1>");


            }
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["id"])))
            {
                Response.WriteAsync("<h2>Hello Mr you aare wrong request </h2>");
                return Content("The Id is must be a positive number please give a value to id  ");

            }
            if (Convert.ToBoolean(Request.Query["isLoggedIn"]) != true)
            {
                Response.StatusCode = 401;
                return Content("The User is not Loged in please login first   ");

            }
            // int bookId = Convert.ToInt32(Request.Query["id"]);
            // good way to access the request object 
            int bookId = Convert.ToInt32((ControllerContext.HttpContext.Request.Query["id"]));
            if (bookId <= 0 || bookId > 1000)
            {
                Response.WriteAsync("<h2>Hello Mr you aare wrong request </h2>");
                return Content("<h1>The Id is must be greater then 0 or less then 1000</h1>");
            }
            return File("/img.png", "image/png");
        }
    }
}
