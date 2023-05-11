using _02_MiddleWares.NewFolder;

namespace _02_MiddleWares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<MiddleWareClass1>(); // custom Middle ware class 
            var app = builder.Build();
            // Midle ware simple
            //app.Run(async (HttpContext context) =>
            //{
            //    context.Response.Headers["Content-Type"] = "text/html";
            //    await context.Response.WriteAsync("<h1>Wellcome To the Middle ware in ASp.Net Core</h2>");
            //});

            //Midle Ware Chain   ###################3
            app.Use(async (HttpContext context, RequestDelegate next) =>
            {
                //   context.Response.Headers["Content-Type"] = "text/html";
                await context.Response.WriteAsync("<p>Hello Ali This responce  " +
                    "from the first middle ware </p>");
                await next(context);
            });
            app.Use(async (HttpContext context1, RequestDelegate next) =>
            {
                await context1.Response.WriteAsync("<p>Hello Ali This responce " +
                    "from the second middle ware </p>");
                await next(context1);
                await context1.Response.WriteAsync("<p>Hello Ali This responce " +
              "ater the 2nd Last request completes  </p>");

            });
            // We used hee the custome middle ware to execute as next middle where 
            // and this class is execute the next middle also
            //   app.UseMiddleware<MiddleWareClass1>(); // syntax for used the middle ware class
            // This is the way to use the extension method as a middle wear

            app.UseMiddleWareClass1();
            app.UseMiddlewareConvension();
            app.Use(async (context2, next) =>
            {
                await context2.Response.WriteAsync("<p>Hello Ali This responce " +
                    "from the Third middle ware </p>");
                await next(context2);
                await context2.Response.WriteAsync("<p>Hello Ali This responce " +
               "ater the end request completes  </p>");
            });
            // Terminatee the middle ware chain
            app.Run(async (HttpContext context) =>
            {
                await context.Response.WriteAsync("<p>This is the End of the Middle wares Pipeline </p>");
            });


            app.Run();
        }
    }
}