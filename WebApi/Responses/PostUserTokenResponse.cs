using PrimitiveTypeObsession.Core.UserToken;

namespace PrimitiveTypeObsession.WebApi.Responses;

public class PostUserTokenResponse
{
    public required UserToken UserToken { get; init; }
    public required Guid Guid { get; init; }
}