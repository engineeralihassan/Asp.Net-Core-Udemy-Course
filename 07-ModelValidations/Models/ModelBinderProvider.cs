using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace _07_ModelValidations.Models
{
    public class ModelBinderProvider : IModelBinderProvider
    {
        IModelBinder? IModelBinderProvider.GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(UserModel))
            {
                return new BinderTypeModelBinder(typeof(
                    CustomeModelBinder));
            }
            return null;
        }
    }
}
