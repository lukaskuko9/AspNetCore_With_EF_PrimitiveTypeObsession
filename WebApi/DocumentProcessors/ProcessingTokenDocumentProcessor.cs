using NJsonSchema;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.ProcessingToken;

namespace PrimitiveTypeObsession.WebApi.DocumentProcessors;

internal class ProcessingTokenDocumentProcessor : IDocumentProcessor
{
    public void Process(DocumentProcessorContext context)
    {
        var co= context.Document.Definitions[nameof(ProcessingToken)];
        co.Description = "My custom description for ProcessingToken";
        co.Example = "string";
        co.Format = "guid";
        co.Type = JsonObjectType.String;
    }
}