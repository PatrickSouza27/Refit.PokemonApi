using Microsoft.AspNetCore.Mvc;
using RefitApiExternalPost.Models;

namespace RefitApiExternalPost.Controllers;

[ApiController]
public class ExternalTestController : ControllerBase
{
    [HttpPost("external")]
    public IActionResult Message([FromBody] Response message)
    {
        return Ok("Refit: a sua mensagem foi : " + message.Message);
    }
}