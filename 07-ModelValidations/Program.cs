namespace _07_ModelValidations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // add model binder provider service 
            builder.Services.AddControllers(//option =>
                                            // {
                                            //  option.ModelBinderProviders.Insert(0, new ModelBinderProvider());
                                            //});)
            );
            // it help to read the data in the form of XML object and bindf this 
            builder.Services.AddControllers().AddXmlSerializerFormatters();
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            app.MapControllers();

            app.Run();
        }
    }
}