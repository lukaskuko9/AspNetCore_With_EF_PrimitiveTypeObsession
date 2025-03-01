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
        var guid = Guid.NewGuid();
        
        var response = await client.PostTokensAsync(new PostUserTokenRequest
        {
            UserAddress = "Prague 1 Made Up Address 37",
            Email = "madeUp@email.com",
            PhoneNumber = null,
            Guid = guid
        });

        return Ok(response);
    }
}