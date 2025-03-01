using NJsonSchema;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.PhoneNumber;

namespace PrimitiveTypeObsession.WebApi.DocumentProcessors;

internal class PhoneNumberDocumentProcessor : IDocumentProcessor
{
    public void Process(DocumentProcessorContext context)
    {
        var co= context.Document.Definitions[nameof(PhoneNumber)];
        co.Description = "My custom description for PhoneNumber";
        co.Example = "string";
        co.Format = "string";
        co.Type = JsonObjectType.String;
    }
}