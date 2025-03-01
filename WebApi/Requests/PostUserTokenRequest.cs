using PrimitiveTypeObsession.Core.Abstractions.GuidWrappers;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.Email;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.PhoneNumber;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.UserAddress;

namespace PrimitiveTypeObsession.WebApi.Requests;

public class PostUserTokenRequest
{
    public Email Email { get; set; }
    public PhoneNumber? PhoneNumber { get; set; }
    public UserAddress UserAddress { get; set; }
    public MyGuid Guid { get; set; }
}