namespace MiddleWearsAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();


            //app.Use(async (HttpContext http, RequestDelegate next) =>
            //{
            //    if (http.Request.Query.ContainsKey("username") && http.Request.Query.ContainsKey("username"))
            //    {
            //        http.Response.Headers["Content-Type"] = "text/html";
            //        await http.Response.WriteAsync("<h1>Log in successfully </h1>");
            //        next(http);
            //    }
            //});
            app.Use(async (HttpContext context, RequestDelegate next) =>
            {
                await context.Response.WriteAsync("<p>Login Div is Here</p>");
                await next(context);
            });
            app.UseWhen(context => context.Request.Query.ContainsKey("userName"),
                app =>
                {
                    app.Use(async (HttpContext context, RequestDelegate next) =>
                    {
                        await context.Response.WriteAsync("<h1>Login Successfully</h1>");
                        await next(context);
                    });
                });
            app.Run(async (HttpContext http) =>
            {

                await http.Response.WriteAsync("<p>The application is Now End </p>");


            });

            app.Run();
        }
    }
}