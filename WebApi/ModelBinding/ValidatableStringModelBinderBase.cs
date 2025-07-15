using Microsoft.AspNetCore.Mvc.ModelBinding;
using PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers;

namespace PrimitiveTypeObsession.WebApi.ModelBinding;

public abstract class ValidatableStringModelBinderBase<TValidatableWrapperType> : IModelBinder
    where TValidatableWrapperType: IValidatableStringWrapper, new()
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        ArgumentNullException.ThrowIfNull(bindingContext);

        var modelName = bindingContext.ModelName;
        var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);
        if (valueProviderResult == ValueProviderResult.None)
            return Task.CompletedTask;

        var value = valueProviderResult.FirstValue;
        if (bindingContext.ModelType != typeof(TValidatableWrapperType) || value is null)
        {
            bindingContext.Result = ModelBindingResult.Failed();
            bindingContext.ActionContext.ModelState.AddModelError(
                modelName,
                $"{typeof(TValidatableWrapperType).Name} cannot be null!"
            );
            return Task.CompletedTask;
        }

        var result = new TValidatableWrapperType
        {
            Value = value
        };

        if (result.IsValid() == false)
        {
            bindingContext.Result = ModelBindingResult.Failed();
            bindingContext.ActionContext.ModelState.AddModelError(
                modelName,
                $"{typeof(TValidatableWrapperType).Name} is invalid!"
            );
            return Task.CompletedTask;
        }
        
        bindingContext.Result = ModelBindingResult.Success(result);
        return Task.CompletedTask;
    }
}