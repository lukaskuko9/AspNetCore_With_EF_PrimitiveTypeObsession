using Microsoft.AspNetCore.Mvc.ModelBinding;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.Email;

namespace PrimitiveTypeObsession.WebApi.ModelBinderProvider;

public class ModelBinderProvider : IModelBinderProvider
{
    public IModelBinder? GetBinder(ModelBinderProviderContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        if (typeof(Email).IsAssignableFrom(context.Metadata.ModelType))
        {
            return new EmailModelBinder();
        }

        return null;
    }
}

public class EmailModelBinder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        ArgumentNullException.ThrowIfNull(bindingContext);

        var modelName = bindingContext.ModelName;
        var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);
        if (valueProviderResult == ValueProviderResult.None)
            return Task.CompletedTask;

        var value = valueProviderResult.FirstValue;
        if (bindingContext.ModelType != typeof(Email) || value is null)
        {
            bindingContext.Result = ModelBindingResult.Failed();
            return Task.CompletedTask;
        }

        var result = new Email(value);
        bindingContext.Result = ModelBindingResult.Success(result);
        return Task.CompletedTask;
    }
}