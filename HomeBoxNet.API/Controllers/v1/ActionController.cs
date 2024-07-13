using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiExplorerSettings(GroupName = "v1")]
[ApiController]
[Route("v1/actions")]
public class ActionController : ControllerBase
{
    [HttpPost("ensure-asset-ids")]
    public IActionResult EnsureAssetIds()
    {
        return Ok();
    }
    
    [HttpPost("ensure-import-refs")]
    public IActionResult EnsureImportRefs()
    {
        return Ok();
    }
    
    [HttpPost("set-primary-photos")]
    public IActionResult SetPrimaryPhotos()
    {
        return Ok();
    }
    
    [HttpPost("zero-item-time-fields")]
    public IActionResult ZeroItemTimeFields()
    {
        return Ok();
    }
}