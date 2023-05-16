namespace _06_ModelBinding_Validations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The Models are used ro get the dat frpm the http requests and pass
            // it to the action methods as parameters
            // // when a specific route is match a specific action method is call befor this call
            // t provides the request data to this method ass parameters
            // 
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}