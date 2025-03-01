using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers;
using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.AccountToken;
using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.ProcessingToken;
using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers.UserToken;

namespace PrimitiveTypeObsession.WebApi.Requests;

public class PostUserTokenRequest
{
    public UserToken UserToken { get; set; }
    public ProcessingToken? ProcessingToken { get; set; }
    public AccountToken AccountToken { get; set; }
    public Guid Guid { get; set; }
}