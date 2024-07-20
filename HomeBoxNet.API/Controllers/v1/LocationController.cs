using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiExplorerSettings(GroupName = "v1")]
[ApiController]
[Route("v1/locations")]
public class LocationController : ControllerBase
{
    [HttpGet]
    public IActionResult GetLocations([FromQuery] GetLocationsQ query)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult CreateLocation()
    {
        return Ok();
    }

    [HttpGet("tree")]
    public IActionResult GetLocationTree([FromQuery] GetLocationTreeQuery query)
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetLocation(Guid id)
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateLocation(Guid id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteLocation(Guid id)
    {
        return Ok();
    }

    public class GetLocationsQ
    {
        public string? FilterChildren { get; set; }
    }

    public class GetLocationTreeQuery
    {
        public bool WithItems { get; set; }
    }
}