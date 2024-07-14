using HomeBoxNet.API.Controllers.v1.Requests;
using HomeBoxNet.API.Controllers.v1.Responses;
using HomeBoxNet.Data;
using HomeBoxNet.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BC = BCrypt.Net.BCrypt;

namespace HomeBoxNet.API.Controllers.v1;

[ApiExplorerSettings(GroupName = "v1")]
[ApiController]
[Route("v1/users")]
public class UserController(AppDbContext context) : ControllerBase
{
    [HttpPost("login")]
    public async Task<LoginResponse?> Login([FromForm] Login user, [FromQuery(Name = "provider")] string? provider)
    {
        // Get the minimum information needed to verify the user login
        var dbUser = await context.Users
            .Where(x => x.Email == user.Username)
            .Select(x => new { x.Password })
            .FirstAsync();
        if (BC.Verify(user.Password, dbUser.Password))
        {
            return new LoginResponse
            {
                Token = "",
                AttachmentToken = "",
                ExpiresAt = DateTime.UtcNow
            };
        }
        return null;
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