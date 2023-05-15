using Microsoft.AspNetCore.Mvc;

namespace _05_Controllers.Controllers
{
    public class IActionResultController : Controller
    {
        public IActionResult Index()
        {
            if (Request.Query.ContainsKey("id"))
            {
                return Content("The Id is note Given by User plese give an propriate id ");

            }
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query.ContainsKey("id"))))
            {
                return Content("The Id is must be a positive number please give a value to id  ");

            }

            // int bookId = Convert.ToInt32(Request.Query["id"]);
            // good way to access the request object 
            int bookId = Convert.ToInt32((ControllerContext.HttpContext.Request.Query["id"]));

        }
    }
}
