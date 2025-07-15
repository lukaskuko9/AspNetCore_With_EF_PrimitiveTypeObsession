using Microsoft.AspNetCore.Mvc.ModelBinding;
using PrimitiveTypeObsession.Core.Abstractions.AccessToken;
using PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.Email;
using PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.PhoneNumber;
using PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.UserAddress;
using PrimitiveTypeObsession.Core.Abstractions.UserToken;

namespace PrimitiveTypeObsession.WebApi.ModelBinding.ModelBinderProvider;

public class ModelBinderProvider : IModelBinderProvider
{
    private readonly Dictionary<Type, IModelBinder> _modelBinders = new()
    {
        { typeof(Email), new EmailModelBinder() },
        { typeof(PhoneNumber), new PhoneNumberBinder() },
        { typeof(UserAddress), new UserAddressBinder() },
        { typeof(UserToken), new UserTokenBinder() },
        { typeof(AccessToken), new AccessTokenBinder() }
    };
    public IModelBinder? GetBinder(ModelBinderProviderContext context)
    {
        ArgumentNullException.ThrowIfNull(context);

        var hasModelBinder = _modelBinders.TryGetValue(context.Metadata.ModelType, out var modelBinder);
        return hasModelBinder ? modelBinder : null;
    }
}

public class EmailModelBinder : ValidatableStringModelBinderBase<Email>;
public class PhoneNumberBinder : ValidatableStringModelBinderBase<PhoneNumber>;
public class UserAddressBinder : ValidatableStringModelBinderBase<UserAddress>;
public class UserTokenBinder : GuidModelBinderBase<UserToken>;
public class AccessTokenBinder : GuidModelBinderBase<AccessToken>;