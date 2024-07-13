using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiController]
[Route("v1")]
public class ItemController : ControllerBase
{
    [HttpGet("assets/{id}")]
    public IActionResult GetAssetById(int id)
    {
        return Ok();
    }
    
    [HttpGet("items")]
    public IActionResult GetItems()
    {
        return Ok();
    }
    
    [HttpPost("items")]
    public IActionResult CreateItem()
    {
        return Ok();
    }
    
    [HttpGet("items/export")]
    public IActionResult ExportItems()
    {
        return Ok();
    }
    
    [HttpGet("items/fields")]
    public IActionResult GetFields()
    {
        return Ok();
    }
    
    [HttpGet("items/fields/values")]
    public IActionResult GetFieldValues()
    {
        return Ok();
    }
    
    [HttpPost("items/import")]
    public IActionResult ImportItems()
    {
        return Ok();
    }
    
    [HttpGet("items/{id}")]
    public IActionResult GetItemById(int id)
    {
        return Ok();
    }
    
    [HttpPut("items/{id}")]
    public IActionResult UpdateItem(int id)
    {
        return Ok();
    }
    
    [HttpDelete("items/{id}")]
    public IActionResult DeleteItem(int id)
    {
        return Ok();
    }
    
    [HttpPatch("items/{id}")]
    public IActionResult PatchItem(int id)
    {
        return Ok();
    }
    
    [HttpGet("items/{id}/path")]
    public IActionResult GetItemPath(int id)
    {
        return Ok();
    }
    
    [HttpGet("qrcode")]
    public IActionResult GetQRCode()
    {
        return Ok();
    }
    
    [HttpGet("items/{id}/attachments/{attachmentId}")]
    public IActionResult GetItemAttachments(int id)
    {
        return Ok();
    }
    
    [HttpPost("items/{id}/attachments")]
    public IActionResult CreateItemAttachment(int id)
    {
        return Ok();
    }
    
    [HttpPut("items/{id}/attachments/{attachmentId}")]
    public IActionResult UpdateItemAttachment(int id)
    {
        return Ok();
    }
    
    [HttpDelete("items/{id}/attachments/{attachmentId}")]
    public IActionResult DeleteItemAttachment(int id)
    {
        return Ok();
    }
    
    [HttpGet("items/{id}/maintenance")]
    public IActionResult GetItemMaintenance(int id)
    {
        return Ok();
    }
    
    [HttpPost("items/{id}/maintenance")]
    public IActionResult CreateItemMaintenance(int id)
    {
        return Ok();
    }
    
    [HttpPut("items/{id}/maintenance/{maintenanceId}")]
    public IActionResult UpdateItemMaintenance(int id)
    {
        return Ok();
    }
    
    [HttpDelete("items/{id}/maintenance/{maintenanceId}")]
    public IActionResult DeleteItemMaintenance(int id)
    {
        return Ok();
    }
}