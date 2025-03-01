using Microsoft.AspNetCore.Mvc;
using PrimitiveTypeObsession.WebApi.Requests;
using PrimitiveTypeObsession.WebApi.Responses;

namespace PrimitiveTypeObsession.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserTokenController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(PostUserTokenResponse), StatusCodes.Status200OK)]
    public IActionResult PostTokens(PostUserTokenRequest request)
    {
        return Ok(new PostUserTokenResponse
        {
            UserToken = request.UserToken,
            Guid = request.Guid
        });
    }
}