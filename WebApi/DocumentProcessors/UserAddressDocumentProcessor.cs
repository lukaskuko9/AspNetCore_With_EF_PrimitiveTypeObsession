using NJsonSchema;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.UserAddress;

namespace PrimitiveTypeObsession.WebApi.DocumentProcessors;

internal class UserAddressDocumentProcessor : IDocumentProcessor
{
    public void Process(DocumentProcessorContext context)
    {
        var co= context.Document.Definitions[nameof(UserAddress)];
        co.Description = "My custom description for UserAddress";
        co.Example = "string";
        co.Format = "string";
        co.Type = JsonObjectType.String;
    }
}