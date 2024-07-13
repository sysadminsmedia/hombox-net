using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiExplorerSettings(GroupName = "v1")]
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
    
    [HttpGet("statistics")]
    public IActionResult GetStatistics()
    {
        return Ok();
    }
    
    [HttpGet("statistics/labels")]
    public IActionResult GetLabelStatistics()
    {
        return Ok();
    }
    
    [HttpGet("statistics/locations")]
    public IActionResult GetLocationStatistics()
    {
        return Ok();
    }
    
    public class PurchasePriceStatisticsQuery
    {
        public string? Start { get; set; }
        public string? End { get; set; }
    }
    
    [HttpGet("statistics/purchase-price")]
    public IActionResult GetPurchasePriceStatistics([FromQuery] PurchasePriceStatisticsQuery query)
    {
        return Ok();
    }
}