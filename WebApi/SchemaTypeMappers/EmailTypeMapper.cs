using Microsoft.OpenApi.Any;
using NJsonSchema;
using NJsonSchema.Generation.TypeMappers;
using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.Email;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.PhoneNumber;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.UserAddress;

namespace PrimitiveTypeObsession.WebApi.SchemaTypeMappers;

public class EmailTypeMapper : ITypeMapper
{
    Type ITypeMapper.MappedType => typeof(Email);

    bool ITypeMapper.UseReference => false;

    void ITypeMapper.GenerateSchema(JsonSchema schema, TypeMapperContext context)
    {
        schema.Id = nameof(Email);
        schema.Description = "It is a email address";
        schema.Type = JsonObjectType.String;
        schema.Format = JsonFormatStrings.Email;
    }
}
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
public class PhoneNumberTypeMapper : ITypeMapper
{
    Type ITypeMapper.MappedType => typeof(PhoneNumber);

    bool ITypeMapper.UseReference => false;

    void ITypeMapper.GenerateSchema(JsonSchema schema, TypeMapperContext context)
    {
        schema.Id = nameof(PhoneNumber);
        schema.Description = "It is a Phone Number";
        schema.Type = JsonObjectType.String;
        schema.Format = JsonFormatStrings.Phone;
    }
}
public class MyGuidTypeMapper : ITypeMapper
{
    Type ITypeMapper.MappedType => typeof(MyGuidTypeMapper);

    bool ITypeMapper.UseReference => false;

    void ITypeMapper.GenerateSchema(JsonSchema schema, TypeMapperContext context)
    {
        schema.Id = nameof(MyGuid);
        schema.Description = "It is a guid";
        schema.Type = JsonObjectType.String;
        schema.Format = JsonFormatStrings.Guid;
    }
}