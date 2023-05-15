using Microsoft.Extensions.FileProviders;

namespace _04_ASp.NetRouting
{
    public class WEbRoutes_StaticFiles
    {
        public static void Main(string[] args)
        {
            {

                var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
                {
                    WebRootPath = "myfiles"
                });

                var app = builder.Build();
                app.UseStaticFiles(); // this is for first files folder
                // if we want to more files related folder do this 


                app.UseStaticFiles(new StaticFileOptions()
                {
                    FileProvider = new PhysicalFileProvider(builder.Environment.ContentRootPath + "\\mywebroot")
                });
                app.UseRouting();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.Map("/", async context =>
                    {
                        await context.Response.WriteAsync("<h1>This is the Home page</h1>");
                    });


                });

                // Last middle wear 
                // ctrl+i = to clear the catche memory


                app.Run(async (HttpContext context) =>
                {
                    await context.Response.WriteAsync($"<p>You are on the the  {context.Request.Path} path</p>");

                });

                app.Run();
            }
        }
    }
}
