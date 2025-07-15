using NJsonSchema;
using NJsonSchema.Generation.TypeMappers;
using PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.PhoneNumber;
using PrimitiveTypeObsession.Core.Abstractions.UserToken;

namespace PrimitiveTypeObsession.WebApi.SchemaTypeMappers;

public class UserTokenTypeMapper : ITypeMapper
{
    Type ITypeMapper.MappedType => typeof(UserToken);

    bool ITypeMapper.UseReference => false;

    void ITypeMapper.GenerateSchema(JsonSchema schema, TypeMapperContext context)
    {
        schema.Id = nameof(UserToken);
        schema.Description = "UserToken belonging to the specific user";
        schema.Type = JsonObjectType.String;
        schema.Format = JsonFormatStrings.Guid;
    }
}