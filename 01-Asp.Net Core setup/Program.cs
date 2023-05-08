namespace _01_Asp.Net_Core_setup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            string message = "Hi Ali Hope All is well This is the first message from the server side kestral is show in the browser";
            app.MapGet("/", () => message);

            app.Run();
        }
    }
}