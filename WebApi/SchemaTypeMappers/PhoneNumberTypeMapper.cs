using NJsonSchema;
using NJsonSchema.Generation.TypeMappers;
using PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.PhoneNumber;

namespace PrimitiveTypeObsession.WebApi.SchemaTypeMappers;

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