using NJsonSchema;
using NJsonSchema.Generation.TypeMappers;
using PrimitiveTypeObsession.Core.Abstractions.AccessToken;
using PrimitiveTypeObsession.Core.Abstractions.UserToken;

namespace PrimitiveTypeObsession.WebApi.SchemaTypeMappers;

public class AccessTokenTypeMapper : ITypeMapper
{
    Type ITypeMapper.MappedType => typeof(AccessToken);

    bool ITypeMapper.UseReference => false;

    void ITypeMapper.GenerateSchema(JsonSchema schema, TypeMapperContext context)
    {
        schema.Id = nameof(AccessToken);
        schema.Description = "Access token of a user";
        schema.Type = JsonObjectType.String;
        schema.Format = JsonFormatStrings.Guid;
    }
}