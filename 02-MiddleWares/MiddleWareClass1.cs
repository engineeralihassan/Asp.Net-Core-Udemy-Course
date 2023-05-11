namespace _02_MiddleWares
{
    public class MiddleWareClass1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("<h3>This Responce is from the custome Midle ware class </h3>");
            await next(context);
            await context.Response.WriteAsync("<h3>This statement is after the next  middle ware code executed  </h3>");


        }
    }
    // clas for extension method to use this class as a method in middle ware 
    public static class MiddleWearExtension
    {
        public static IApplicationBuilder UseMiddleWareClass1(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MiddleWareClass1>();
        }
    }
}
