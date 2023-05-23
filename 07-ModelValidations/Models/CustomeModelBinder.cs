using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace _07_ModelValidations.Models
{
    public class CustomeModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            UserModel obj = new UserModel();

            if (bindingContext.ValueProvider.GetValue("firstname").Length > 0)
            {
                obj.Name = bindingContext.ValueProvider.GetValue("firstname").FirstValue;
            }
            if (bindingContext.ValueProvider.GetValue("lastname").Length > 0)
            {
                obj.Name += " " + bindingContext.ValueProvider.GetValue("lastname").FirstValue;
            }
            bindingContext.Result = ModelBindingResult.Success(obj);
            return Task.CompletedTask;
        }
    }
}
