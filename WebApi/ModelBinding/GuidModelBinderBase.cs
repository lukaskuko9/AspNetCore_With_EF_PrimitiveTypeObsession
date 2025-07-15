using Microsoft.AspNetCore.Mvc.ModelBinding;
using PrimitiveTypeObsession.Core.Abstractions;

namespace PrimitiveTypeObsession.WebApi.ModelBinding;

public abstract class GuidModelBinderBase<TGuidType> : IModelBinder
    where TGuidType: IGuidWrapper<TGuidType>, new()
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        ArgumentNullException.ThrowIfNull(bindingContext);

        var modelName = bindingContext.ModelName;
        var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);
        if (valueProviderResult == ValueProviderResult.None)
            return Task.CompletedTask;

        var value = valueProviderResult.FirstValue;
        if (bindingContext.ModelType != typeof(TGuidType) || value is null)
        {
            bindingContext.Result = ModelBindingResult.Failed();
            bindingContext.ActionContext.ModelState.AddModelError(
                modelName,
                $"{typeof(TGuidType).Name}: Value cannot be null!"
            );
            
            return Task.CompletedTask;
        }
        
        if (Guid.TryParse(value, out var parsedGuid) == false)
        {
            bindingContext.Result = ModelBindingResult.Failed();
            bindingContext.ActionContext.ModelState.AddModelError(
                modelName, 
                $"{typeof(TGuidType).Name}: Guid is in an invalid format!"
            );
            return Task.CompletedTask;
        }
        
        var result = new TGuidType
        {
            Value = parsedGuid
        };

        bindingContext.Result = ModelBindingResult.Success(result);
        return Task.CompletedTask;
    }
}