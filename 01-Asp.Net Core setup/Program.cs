namespace _01_Asp.Net_Core_setup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            string message = "Hi Ali Hope All is well This is the first message" +
                " from the server side kestral is show in the browser";
            string message2 = "This is the text of the second Message from the user";
            //   app.MapGet("/", () => message);// in the place of this line we could also make our custom code and response error s
            app.Run(async (HttpContext context) =>
            {
                var path = context.Request.Path;

                if (1 == 1)

                {

                    // responce  Headers
                    context.Response.Headers["Status"] = "Successfull Call ";
                    // content Type 
                    context.Response.Headers["Content-Type"] = "text/html";
                    // status codes 
                    context.Response.StatusCode = 200;
                    // Responce
                    await context.Response.WriteAsync(message);
                    await context.Response.WriteAsync(message2);
                    // HTTP request Query parameters
                    if (context.Request.Query.ContainsKey("id"))
                    {
                        var id = context.Request.Query["id"];
                        var name = context.Request.Query["name"];

                        await context.Response.WriteAsync($"<h2>This course id is {id} and name is {name}</h2> ");
                    }

                    if (path == "/")
                    {

                        await context.Response.WriteAsync("<p>You are At the Home page</p>");

                    }
                    else
                    {

                        await context.Response.WriteAsync("<p>You are not at Home Page </p>");
                    }
                    // Request headers
                    if (context.Request.Headers.ContainsKey("User-Agent"))
                    {
                        var userBrowser = context.Request.Headers["User-Agent"];
                        await context.Response.WriteAsync($"<p> {userBrowser} </p> ");


                    }

                }
                else
                {
                    context.Response.Headers["Status"] = "Fail  Requests";
                    context.Response.Headers["Content-Type"] = "text/html";
                    context.Response.Headers["Server"] = "Hostinger Desktop123";

                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync("<h3>Sorry You request is not a proper request <h1>401</h1></h3>");
                    await context.Response.WriteAsync(
                        "<h4>Try again with proper Text</h4>");
                    // HTTP request

                    if (path == "/")
                    {

                        await context.Response.WriteAsync("<p>You are At the Home page </p>");


                    }
                    else
                    {

                        await context.Response.WriteAsync("<p>You are not at Home Page </p>");
                    }


                }
                // HTTP request

                if (path == "/")
                {
                    context.Response.Headers["Content-Type"] = "text/html";
                    await context.Response.WriteAsync("<p>You are At the Home page <p>");


                }
                else
                {
                    context.Response.Headers["Content-Type"] = "text/html";
                    await context.Response.WriteAsync("<p>You are not at Home Page <p>");
                }

                // This is for send the post request from postman
                context.Response.Headers["Content-type"] = "text/html";
                //context.Request.Headers["AuthorizationKey"] = "alihassan5063";


                // StreamReader reader = new StreamReader(context.Request.Body);
                //string body = await reader.ReadToEndAsync();



                // await context.Response.WriteAsync($"<p> Theproperty is  is :  {body}</p> ");

                // await context.Response.WriteAsync($"<p> Theproperty is  is </p> ");
                //string auth = context.Request.Headers["AuthorizationKey"];
                //await context.Response.WriteAsync($"<p>The Key is :</p>");

            });

            app.Run();

        }
    }
}