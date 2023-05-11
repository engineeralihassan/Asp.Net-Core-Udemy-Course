namespace _02_MiddleWares.NewFolder
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareConvension
    {
        private readonly RequestDelegate _next;

        public MiddlewareConvension(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Query.ContainsKey("firstName"))
            {
                string firstname = httpContext.Request.Query["firstName"];
                string lastName = httpContext.Request.Query["lastName"];
                string fullName = firstname + " " + lastName;
                await httpContext.Response.WriteAsync($"<h4>The full from the middleWare" +
                    $" convension Class{fullName}</h4>");


            }
            await _next(httpContext);
            await httpContext.Response.WriteAsync($"<h4>The After logic code of middleware convension </h4>");

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareConvensionExtensions
    {
        public static IApplicationBuilder UseMiddlewareConvension(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareConvension>();
        }
    }
}
