namespace _04_ASp.NetRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            // ########################################################### GetEndPoints()
            // End points befor UseRouting()= null always
            //app.Use(async (HttpContext context, RequestDelegate next) =>
            //{
            //    await context.Response.WriteAsync($"<p>The GetEndPoints method befor the UseRouting is always null</p>");
            //    Microsoft.AspNetCore.Http.Endpoint? endPoint = context.GetEndpoint();
            //    await context.Response.WriteAsync($"<p>The EndsPoints object is Null</p>");
            //    next(context);
            //});
            app.UseRouting();
            //app.Use(async (HttpContext context, RequestDelegate next) =>
            //{
            //    await context.Response.WriteAsync($"<p>The GetEndPoints method After the UseRouting</p>");
            //    Microsoft.AspNetCore.Http.Endpoint? endPoint = context.GetEndpoint();
            //    if (endPoint != null)
            //    {
            //        await context.Response.WriteAsync($"<p>EndPoints name : {endPoint.DisplayName} </p>");

            //    }
            //    await context.Response.WriteAsync($"<p>The endpoints objct have values  </p>");



            //});
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/user", async context =>
            //    {
            //        context.Response.Headers["Content-Type"] = "text/html";
            //        await context.Response.WriteAsync("<h1>Welcome Dear User</h1>");
            //    });

            //    endpoints.MapGet("/admin", async context =>
            //    {
            //        await context.Response.WriteAsync("<h1>Wecome Mr Admin</h1>");
            //    });
            //    endpoints.MapPost("/client", async context =>
            //    {
            //        await context.Response.WriteAsync("<h1>Wecome Mr Admin</h1>");
            //    });
            //});
            //
            //   ################################################# Route parameters | defualt parameters | optional parameters
            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/files/{filename=data}.{extension=pdf}", async context =>
                {
                    string? name = Convert.ToString(context.Request.RouteValues["filename"]);
                    string? extension = Convert.ToString(context.Request.RouteValues["extension"]);


                    context.Response.Headers["Content-Type"] = "text/html";
                    await context.Response.WriteAsync($"<h1>The File is {name} - {extension} </h1>");

                });
                endpoints.Map("/profiles/profile/{name=AliHassan }", async context =>
                {
                    string? name = Convert.ToString(context.Request.RouteValues["name"]);



                    context.Response.Headers["Content-Type"] = "text/html";
                    await context.Response.WriteAsync($"<h1>The Employ is {name} </h1>");

                });

                endpoints.Map("/users/user/{name?}", async context =>
                {
                    string? name = "";
                    if (context.Request.RouteValues.ContainsKey("name"))
                    {
                        name = Convert.ToString(context.Request.RouteValues["name"]);
                        await context.Response.WriteAsync($"<h1>The Employ: {name}  : Avaliable </h1>");
                    }
                    else
                    {
                        await context.Response.WriteAsync($"<h1>The Employ: {name} : Not available </h1>");
                    }




                    context.Response.Headers["Content-Type"] = "text/html";
                    await context.Response.WriteAsync($"<h1>The Employ is {name} </h1>");

                });







                endpoints.MapGet("/admin", async context =>
                {
                    await context.Response.WriteAsync("<h1>Wecome Mr Admin</h1>");
                });
                endpoints.MapPost("/client", async context =>
                {
                    await context.Response.WriteAsync("<h1>Wecome Mr Admin</h1>");
                });
            });
            // Last middle wear 

            app.Run(async (HttpContext context) =>
            {
                await context.Response.WriteAsync($"<p>You are on the the  {context.Request.Path}</p>");

            });

            app.Run();
        }
    }
}