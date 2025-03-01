using NJsonSchema;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.Email;

namespace PrimitiveTypeObsession.WebApi.DocumentProcessors;

internal class EmailDocumentProcessor : IDocumentProcessor
{
    public void Process(DocumentProcessorContext context)
    {
        var co= context.Document.Definitions[nameof(Email)];
        co.Description = "My custom description for Email";
        co.Example = "string";
        co.Format = "string";
        co.Type = JsonObjectType.String;
    }
}