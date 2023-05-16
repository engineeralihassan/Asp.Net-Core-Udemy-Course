using Microsoft.AspNetCore.Mvc;

namespace _05_Controllers.Controllers
{
    public class StoreController : Controller
    {
        [Route("books/stor/{id}")]
        public IActionResult BookStor()
        {
            int id = Convert.ToInt32(Request.RouteValues["id"]);

            return Content($"<h1>Wellcome to Books store and book id is : {id}</h1>", "text/html");

        }
    }
}
