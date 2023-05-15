
using _05_Controllers.Models;

using Microsoft.AspNetCore.Mvc;

namespace _05_Controllers.Controllers
{
    [Controller]
    public class ContentResultController : Controller
    {

        [Route("users")]
        public ContentResult Method1()
        {
            return Content("<h1>This is the result from the Controller content type </h1>", "text/html");

        }
        [Route("persons/person")]
        public JsonResult Method2()
        {
            PersonModel personModel = new PersonModel()
            {
                Id = new Guid(),
                Name = "Ali Hassan",
                Description = "I am the Student of the BS software enginerring 8th samester ",
                Address = "Chack no 11/1L Renala khurd ",
                City = "Okara "


            };
            // return new JsonResult(personModel);
            // also use this 
            return Json(personModel);

        }
        // Filecontent Type
        [Route("files/dounload")]
        public VirtualFileResult DownloadFile()
        {
            //  return new VirtualFileResult("/img.png", "image/png");
            // we a;so write this 
            return File("/img.png", "image/png");
        }
        // physicalfile resu;t
        [Route("files/dounloads/download")]
        public PhysicalFileResult DownloadFile1()
        {
            // return new PhysicalFileResult("C:\\Users\\Ali Hassan\\Pictures\\Screenshots\\sc.png", "image/png");
            return PhysicalFile("C:\\Users\\Ali Hassan\\Pictures\\Screenshots\\sc.png", "image/png");
        }
        // File content  resu;t
        [Route("books/dounloads/book")]
        public FileContentResult DownloadFile2()
        {
            byte[] bytes = System.IO.File.ReadAllBytes("D:\\Downloads\\csharpDsa.pdf");
            return File(bytes, "application/pdf");
        }

    }


}
