using Microsoft.AspNetCore.Mvc;
using Refit.Services;
using RefitApiExternalPost.Models;

namespace Refit.Controller;

public class ExternalController : ControllerBase
{
    private readonly IExternalApi _externalApi;
    
    public ExternalController(IExternalApi externalApi)
    {
        _externalApi = externalApi;
    }
    
    [HttpPost("api/external")]
    public async Task<IActionResult> Message([FromBody] Response message)
    {
        var response = await _externalApi.Message(message);
        return Ok(response);
    }
}