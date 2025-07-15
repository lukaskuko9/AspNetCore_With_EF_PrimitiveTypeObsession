using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimitiveTypeObsession.Core.Abstractions.UserToken;

namespace PrimitiveTypeObsession.Infrastructure.Database.Extensions;

internal static class UserTokenBuilderExtensions
{
    /// <summary>
    /// Entity Framework needs to be told about conversion from UserToken to primitive type value and back,
    /// otherwise it results in errors. This extension method adds the conversion to non-nullable primitive type value
    /// </summary>
    /// <param name="propertyBuilder">Property builder from model builder</param>
    /// <returns>Property builder with added conversion</returns>
    public static PropertyBuilder<UserToken> AddUserTokenConversion(this PropertyBuilder<UserToken> propertyBuilder)
    {
        var propBuilderWithConversion = propertyBuilder
            .HasConversion(userToken => userToken.Value, guid => new UserToken(guid));
        
        return propBuilderWithConversion;
    }

    /// <summary>
    /// Entity Framework needs to be told about conversion from UserToken to primitive type value and back,
    /// otherwise it results in errors. This extension method adds the conversion to nullable primitive type value
    /// </summary>
    /// <param name="propertyBuilder">Property builder from model builder</param>
    /// <returns>Property builder with added conversion</returns>
    public static PropertyBuilder<UserToken?> AddUserTokenConversion(this PropertyBuilder<UserToken?> propertyBuilder)
    {
        var propBuilderWithConversion = propertyBuilder
            .HasConversion(userToken =>
                    userToken.HasValue ? userToken.Value.Value : (Guid?)null,
                guid => guid == null ? null : new UserToken(guid.Value)
            );
        return propBuilderWithConversion;
    }

}