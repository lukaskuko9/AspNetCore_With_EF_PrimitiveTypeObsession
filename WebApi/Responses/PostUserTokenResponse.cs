using PrimitiveTypeObsession.Core.Abstractions.AccessToken;
using PrimitiveTypeObsession.Core.Abstractions.UserToken;

namespace PrimitiveTypeObsession.WebApi.Responses;

public class PostUserTokenResponse
{
    public AccessToken AccessToken { get; set; }
    public UserToken UserToken { get; set; }
}