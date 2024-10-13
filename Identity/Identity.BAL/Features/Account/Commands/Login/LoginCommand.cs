namespace Identity.BAL.Features.Account.Commands.Login;

public record LoginCommand : IRequest<LoginCommandResponse>
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
