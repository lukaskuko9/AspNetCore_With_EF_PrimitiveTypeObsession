using NJsonSchema;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.UserAddress;

namespace PrimitiveTypeObsession.WebApi.DocumentProcessors;

internal class MyGuidDocumentProcessor : IDocumentProcessor
{
    public void Process(DocumentProcessorContext context)
    {
        var co= context.Document.Definitions[nameof(MyGuid)];
        co.Description = "My custom description for MyGuid";
        co.Example = "string";
        co.Format = "guid";
        co.Type = JsonObjectType.String;
    }
}