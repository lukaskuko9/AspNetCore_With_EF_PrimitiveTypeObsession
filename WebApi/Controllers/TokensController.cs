using Microsoft.AspNetCore.Mvc;
using PrimitiveTypeObsession.WebApi.Requests;
using PrimitiveTypeObsession.WebApi.Responses;

namespace PrimitiveTypeObsession.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TokensController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(PostUserTokenResponse), StatusCodes.Status200OK)]
    public IActionResult PostTokens(PostUserTokenRequest request)
    {
        return Ok(new PostUserTokenResponse
        {
            AccessToken = request.AccessToken,
            UserToken = request.UserToken,
        });
    }
}