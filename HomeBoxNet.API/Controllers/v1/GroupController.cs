using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiController]
[Route("v1/groups")]
public class GroupController : ControllerBase
{
    [HttpGet]
    public IActionResult GetGroup()
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult Update()
    {
        return Ok();
    }

    [HttpPost("invitations")]
    public IActionResult CreateInvite()
    {
        return Ok();
    }
}