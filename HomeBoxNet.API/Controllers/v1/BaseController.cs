using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiExplorerSettings(GroupName = "v1")]
[ApiController]
[Route("v1")]
public class BaseController : ControllerBase
{
    [HttpGet("currency")]
    public IActionResult GetCurrency()
    {
        return Ok();
    }

    [HttpGet("status")]
    public IActionResult GetStatus()
    {
        return Ok();
    }
}