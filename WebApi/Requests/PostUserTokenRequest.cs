using PrimitiveTypeObsession.Core.Abstractions.AccessToken;
using PrimitiveTypeObsession.Core.Abstractions.UserToken;

namespace PrimitiveTypeObsession.WebApi.Requests;

public class PostUserTokenRequest
{
    public AccessToken AccessToken { get; set; }
    public UserToken UserToken { get; set; }
}