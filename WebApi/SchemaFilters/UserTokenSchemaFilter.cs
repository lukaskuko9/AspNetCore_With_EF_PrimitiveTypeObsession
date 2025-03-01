using NJsonSchema;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using PrimitiveTypeObsession.Core.UserToken;

namespace PrimitiveTypeObsession.WebApi.SchemaFilters;

public class UserTokenDocumentProcessor : IDocumentProcessor
{
    public void Process(DocumentProcessorContext context)
    {
        var co= context.Document.Definitions[nameof(UserToken)];
        co.Description = "My custom description for UserToken";
        co.Example = "string";
        co.Format = "guid";
        co.Type = JsonObjectType.String;
    }
}