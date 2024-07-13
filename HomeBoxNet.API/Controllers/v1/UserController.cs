using HomeBoxNet.Data;
using HomeBoxNet.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;

[ApiExplorerSettings(GroupName = "v1")]
[ApiController]
[Route("v1/users")]
public class UserController(AppDbContext context) : ControllerBase
{
    
    [HttpPost("login")]
    public IActionResult Login([FromBody] User user)
    {
        var dbUser = context.Users.First(x => x.Email == user.Email);
        if (dbUser.Password == user.Password)
        {
            return Ok();
        }
        return Unauthorized();
    }
    
    [HttpPost("logout")]
    public IActionResult Logout()
    {
        return Ok();
    }
    
    [HttpGet("refresh")]
    public IActionResult Refresh()
    {
        return Ok();
    }

    [HttpGet("self")]
    public User GetSelf()
    {
        return context.Users.First(x => x.Id == new Guid(User.Identity.Name));
    }
    
    [HttpPost("register")]
    public IActionResult Register([FromBody] User user)
    {
        context.Users.Add(user);
        context.SaveChanges();
        return CreatedAtRoute("self", user);
    }
    
    [HttpPost("change-password")]
    public IActionResult ChangePassword([FromBody] string password)
    {
        var user = context.Users.First(x => x.Id == new Guid(User.Identity.Name));
        user.Password = password;
        context.SaveChanges();
        return Ok();
    }

    [HttpPut("self")]
    public IActionResult Update([FromBody] User user)
    {
        return Ok();
    }
    
    [HttpDelete("self")]
    public IActionResult Delete()
    {
        var user = context.Users.First(x => x.Id == new Guid(User.Identity.Name));
        context.Users.Remove(user);
        context.SaveChanges();
        return Ok();
    }
}