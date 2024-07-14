namespace HomeBoxNet.API.Controllers.v1.Responses;

public class LoginResponse
{
    public required string AttachmentToken { get; set; }
    public required DateTime ExpiresAt { get; set; }
    public required string Token { get; set; }
}