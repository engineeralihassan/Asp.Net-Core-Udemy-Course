using _07_ModelValidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07_ModelValidations.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("<h1>Ellcome Back to Asp.net core Model Validations topic <h1>", "text/html");
        }
        [Route("users/user")]
        public IActionResult User(UserModel user)
        {

            if (!ModelState.IsValid)
            {
                string errors = string.Join("/n",
                ModelState.Values.SelectMany(x => x.Errors).ToList()  // as outer loop
               .Select(error => error.ErrorMessage).ToList());  // as inner loop
                                                                // We also do this with linQ 

                //foreach (var value in ModelState.Values)
                //{
                //    foreach (var error in value.Errors)
                //    {
                //        errors.Add(error.ErrorMessage);
                //    }
                //}
                //  string error1 = string.Join("\n", errors);

                return BadRequest($"{errors}");
            }
            return Content($"<h5>User Details {user} </h5>", "text/html");
        }
    }
}
