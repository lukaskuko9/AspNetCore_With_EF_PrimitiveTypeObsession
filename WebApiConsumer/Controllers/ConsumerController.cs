using Microsoft.AspNetCore.Mvc;
using WebApiConsumer.GeneratedClient;

namespace WebApiConsumer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsumerController(MyGeneratedClient client) : ControllerBase
{
    [HttpPost("userToken")]
    public async Task<IActionResult> PostUserTokenToWebApi()
    {
        var accountToken = Guid.NewGuid();
        var guid = Guid.NewGuid();
        var processingToken = Guid.NewGuid();
        var userToken = Guid.NewGuid();
        
        var response = await client.PostTokensAsync(new PostUserTokenRequest
        {
            UserToken = userToken,
            AccountToken = accountToken,
            ProcessingToken = processingToken,
            Guid = guid
        });

        return Ok(response);
    }
}