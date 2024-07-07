using HomeBoxNet.Data;
using HomeBoxNet.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeBoxNet.API.Controllers.v1;


[ApiController]
[Route("v1/[controller]")]
public class UserController(AppDbContext context) : ControllerBase
{

    [HttpGet(Name = "GetUsers")]
    public IEnumerable<User> GetUsers()
    {
        return context.Users;
    }
}