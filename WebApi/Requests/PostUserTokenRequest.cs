using PrimitiveTypeObsession.Core.UserToken;

namespace PrimitiveTypeObsession.WebApi.Requests;

public class PostUserTokenRequest
{
    public UserToken UserToken { get; set; }
    public Guid Guid { get; set; }
}