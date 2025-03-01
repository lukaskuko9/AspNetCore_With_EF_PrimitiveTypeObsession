using NJsonSchema;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.AccountToken;

namespace PrimitiveTypeObsession.WebApi.DocumentProcessors;

internal class AccountTokenDocumentProcessor : IDocumentProcessor
{
    public void Process(DocumentProcessorContext context)
    {
        var co= context.Document.Definitions[nameof(AccountToken)];
        co.Description = "My custom description for AccountToken";
        co.Example = "string";
        co.Format = "guid";
        co.Type = JsonObjectType.String;
    }
}