namespace HomeBoxNet.API.Controllers.v1.Requests;

public class Login
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}