using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiController]
[Route("v1/labels")]
public class LabelController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult Create()
    {
        return Ok();
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        return Ok();
    }
    
    [HttpPut("{id}")]
    public IActionResult Update(Guid id)
    {
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        return Ok();
    }
}