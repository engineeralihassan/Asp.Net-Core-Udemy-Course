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
        // Bind or never Bind 
        //public IActionResult User([Bind(typeof(UserModel.Name),typeof(UserModel.email),
        //    typeof(UserModel.presentAge))]UserModel user)
        //  public IActionResult User([Bind("Name", "email", "age", "presentAge")] UserModel user)
        // Json object [fromBody]
        //  public IActionResult User([FromBody] UserModel user)
        // Custome model binder 

        //public IActionResult User([ModelBinder(BinderType =
        //    typeof(CustomeModelBinder))] UserModel user)
        // this is not good to write the lenthy code for every action method
        // we wrtite this once for the custome moddel binder provider
        // Form Headers
        public IActionResult User(UserModel user, [FromHeader(Name = "User-Agent")] string UserAgent)
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
            return Content($"<h5>User Details {user}:{UserAgent} </h5>", "text/html");
        }
    }
}
