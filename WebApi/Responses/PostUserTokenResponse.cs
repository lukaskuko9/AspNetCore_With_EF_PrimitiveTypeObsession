using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.Email;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.PhoneNumber;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.UserAddress;

namespace PrimitiveTypeObsession.WebApi.Responses;

public class PostUserTokenResponse
{
    public required Email Email { get; init; }
    public required PhoneNumber? PhoneNumber { get; init; }
    public required UserAddress UserAddress { get; init; }
    public required MyGuid Guid { get; init; }
}