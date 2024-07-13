using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiController]
[Route("v1/reporting")]
public class ReportingController : ControllerBase
{
    [HttpGet("bill-of-materials")]
    public IActionResult GetBillOfMaterials()
    {
        return Ok();
    }
}