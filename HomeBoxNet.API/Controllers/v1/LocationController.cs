using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiController]
[Route("v1/locations")]
public class LocationController : ControllerBase
{
    [HttpGet]
    public IActionResult GetLocations()
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult CreateLocation()
    {
        return Ok();
    }
    
    [HttpGet("tree")]
    public IActionResult GetLocationTree()
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
}