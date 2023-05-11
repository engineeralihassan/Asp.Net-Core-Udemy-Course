using System.Net;

namespace AssignmentHeaders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (HttpContext context) =>
            {
                context.Response.Headers["Content-type"] = "text/html";
                var path = context.Request.Path;
                //var number1 = context.Request.Query["number1"];
                //var number2 = context.Request.Query["number2"];
                //var op = context.Request.Query["operator"];
                // URL decode the values
                string Number1 = WebUtility.UrlDecode(context.Request.Query["number1"]);
                string Number2 = WebUtility.UrlDecode(context.Request.Query["number2"]);
                var Operator = context.Request.Query["operator"];
                int num1 = int.Parse(Number1);
                int num2 = int.Parse(Number2);


                dynamic result;

                switch (context.Request.Query["operator"])
                {
                    case "add":
                        // Convert the numbers to integers
                        context.Response.StatusCode = 200;

                        result = num1 + num2;
                        break;
                    case "sub":
                        // Convert the numbers to integers
                        context.Response.StatusCode = 200;

                        result = num1 - num2;
                        break;
                    case "multiply":
                        // Convert the numbers to integers
                        context.Response.StatusCode = 200;

                        result = num1 * num2;
                        break;

                    default:
                        context.Response.StatusCode = 400;
                        result = "Please enter correct operator";
                        break;
                }








                await context.Response.WriteAsync($"<h2>The ' {Operator} ' of {Number1} and {Number2} = {result} </h2> ");

            });

            app.Run();
        }
    }
}