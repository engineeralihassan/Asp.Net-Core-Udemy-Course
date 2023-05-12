namespace _03ModdleWearAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Use(async (HttpContext http, RequestDelegate next) =>
            {
                if (http.Request.Query.ContainsKey("username") && http.Request.Query.ContainsKey("username"))
                {
                    await http.Response.WriteAsync("<h1>Log in successfully </h1>");
                    next(http);
                }
            });

            app.Run(async (HttpContext http) =>
            {

                await http.Response.WriteAsync("<p>The application is Now End </p>");


            });
        }
    }
}