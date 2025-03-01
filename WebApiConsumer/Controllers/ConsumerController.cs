using Infrastructure.MyGeneratedClient;
using Microsoft.AspNetCore.Mvc;

namespace WebApiConsumer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsumerController(MyGeneratedClient client) : ControllerBase
{
    [HttpPost("userToken")]
    public async Task<IActionResult> PostUserTokenToWebApi()
    {
        var userToken = Guid.NewGuid();
        var guid = Guid.NewGuid();
        
        var response = await client.PostTokensAsync(new PostUserTokenRequest
        {
            UserToken = userToken,
            Guid = guid
        });

        return Ok(response);
    }
}