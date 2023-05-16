
using Microsoft.AspNetCore.Mvc;

namespace _06_ModelBinding_Validations.Controllers
{
    [Controller]
    public class ModelBindingController : Controller
    {
        [Route("books")]
        [Route("/")]

        public IActionResult Index()
        {
            return Content("<h1>Wellcome to book store </h1>", "text/html");
        }
        [Route("books/book")]
        public IActionResult Index(int? id1, string name, Boolean isLoggedIn)
        {
            if (id1.HasValue == false)
            {
                return Content($"<h1>please enter Book Id :  [{id1}] : [{name}] </h1>", "text/html");
            }
            if (isLoggedIn == false)
            {
                return Content($"<h1>Please login First then get book </h1>", "text/html");
            }
            return Content($"<h1>The Book is available :  [{id1}] : [{name}] </h1>", "text/html");

        }
        // Route values with model binding ################3
        [Route("booksstore/{bookname?}/{bookid?}")]
        public IActionResult Index(string bookname, int bookid)
        {
            if (String.IsNullOrEmpty(bookname) || bookid.Equals(false))
            {
                return Content($"<h1>Wrong information no book found with  :  [{bookname}] : [{bookid}] </h1>", "text/html");
            }

            return Content($"<h1>The Book is Found  :  [{bookname}] : [{bookid}] </h1>", "text/html");

        }
        // From Route and From Query 
        [Route("users/user/{userid?}")]
        public IActionResult Users([FromRoute] int userid)
        {
            if (userid > 0)
            {
                return Content($"<h1>The user is Found :  [{userid}] </h1>", "text/html");
            }

            return Content($"<h1>The user is not available with this id   : [{userid}] </h1>", "text/html");

        }
        // FromQuery 
        [Route("sellers/seller")]
        public IActionResult Users(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return Content($"<h1>The user is Found :  [{name}] </h1>", "text/html");
            }

            return Content($"<h1>The user is not available with this name  : [{name}] </h1>", "text/html");

        }

    }
}
