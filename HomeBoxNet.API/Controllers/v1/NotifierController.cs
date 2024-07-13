using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiController]
[Route("v1/notifiers")]
public class NotifierController : ControllerBase
{
    [HttpGet]
    public IActionResult GetNotifiers()
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult CreateNotifier()
    {
        return Ok();
    }
    
    [HttpPost("test")]
    public IActionResult TestNotifier()
    {
        return Ok();
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateNotifier()
    {
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteNotifier()
    {
        return Ok();
    }
}