using HomeBoxNet.Data;
using HomeBoxNet.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiExplorerSettings(GroupName = "v1")]
[ApiController]
[Route("v1/users")]
public class UserController(AppDbContext context) : ControllerBase
{
    [HttpGet("self")]
    public User GetSelf()
    {
        return context.AppUsers.First(x => x.Id == new Guid("00000000-0000-0000-0000-000000000000"));
    }
}