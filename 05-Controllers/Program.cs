namespace _05_Controllers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Before IActionResult #################################

            var builder = WebApplication.CreateBuilder(args);
            // this is used to add  ll the controller classes for used  as services
            // only by one command not one by one 
            builder.Services.AddControllers();

            var app = builder.Build();
            app.UseRouting();
            /*
          app.UseEndpoints(endpoints =>
          {
              // Its used to Enable the routings for each action methods 
              endpoints.MapControllers();
          });

          // app.MapGet("/", () => "Hello World!"); This code is not necdessary ot run the code

          */
            //  IActionResult  Controller ##################
            app.MapControllers();
            app.Run();
        }
    }
}