using Microsoft.OpenApi.Any;
using NJsonSchema;
using NJsonSchema.Generation.TypeMappers;
using PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.Email;

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