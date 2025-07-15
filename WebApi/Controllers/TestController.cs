using Microsoft.AspNetCore.Mvc;
using PrimitiveTypeObsession.Core.Abstractions.Showcase.StringWrappers.Email;

namespace PrimitiveTypeObsession.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpPost("uri/{email}")]
    public Task<IActionResult> UriParameterTest([FromRoute]Email email)
    {
        return Task.FromResult<IActionResult>(Ok(new EmailResponse
        {
            Email = email
        }));
    }

    [HttpPost("queryTest")]
    public Task<IActionResult> QueryParameterTest([FromQuery] Email email)
    {
        return Task.FromResult<IActionResult>(Ok(new EmailResponse
        {
            Email = email
        }));
    }

    [HttpPost("bodyTest")]
    public Task<IActionResult> QueryParameterTest([FromBody] EmailRequest request)
    {
        return Task.FromResult<IActionResult>(Ok(new EmailResponse
        {
            Email = request.Email
        }));
    }
}

public class EmailResponse
{
    public required Email Email { get; set; }
}

public class EmailRequest
{
    public required Email Email { get; set; }
}

