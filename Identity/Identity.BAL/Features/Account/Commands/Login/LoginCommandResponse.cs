namespace Identity.BAL.Features.Account.Commands.Login;

public record LoginCommandResponse
{
    public required string AccessToken { get; set; }
    public required string RefreshToken { get; set; }
}
