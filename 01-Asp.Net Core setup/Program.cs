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

                if (1 == 2)
                {
                    context.Response.Headers["Status"] = "Successfull Call ";

                    context.Response.StatusCode = 200;
                    await context.Response.WriteAsync(message);
                    await context.Response.WriteAsync(message2);
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


                }



            });

            app.Run();

        }
    }
}