using NJsonSchema;
using NJsonSchema.Generation.TypeMappers;
using PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.UserAddress;

namespace PrimitiveTypeObsession.WebApi.SchemaTypeMappers;

public class UserAddressTypeMapper : ITypeMapper
{
    Type ITypeMapper.MappedType => typeof(UserAddress);
    bool ITypeMapper.UseReference => false;

    void ITypeMapper.GenerateSchema(JsonSchema schema, TypeMapperContext context)
    {
        schema.Id = nameof(UserAddress);
        schema.Description = "It is a User address";
        schema.Type = JsonObjectType.String;
    }
}