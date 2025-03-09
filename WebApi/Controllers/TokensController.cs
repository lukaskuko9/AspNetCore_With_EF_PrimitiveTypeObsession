using Microsoft.AspNetCore.Mvc;
using PrimitiveTypeObsession.Core.Abstractions.StringWrappers.Email;
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
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            UserAddress = request.UserAddress,
            Guid = request.Guid,
        });
    }
}