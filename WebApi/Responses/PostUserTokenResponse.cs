using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers;
using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.AccountToken;
using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.ProcessingToken;
using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.UserToken;

namespace PrimitiveTypeObsession.WebApi.Responses;

public class PostUserTokenResponse
{
    public required UserToken UserToken { get; init; }
    public required ProcessingToken? ProcessingToken { get; init; }
    public required AccountToken AccountToken { get; init; }
    public required Guid Guid { get; init; }
}