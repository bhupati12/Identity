using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Identity.BAL.Features.Account.Commands.Login;

public class LoginCommandHandler(IOptions<JWTOptions> options) : IRequestHandler<LoginCommand, LoginCommandResponse>
{
    public Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    private string GenerateToken(ApplicationUser user)
    {
        var handler = new JwtSecurityTokenHandler();
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Value.Key));

        var token = new JwtSecurityToken(
            issuer: options.Value.Issuer,
            audience: options.Value.Audience,
            claims: null,
            expires: DateTime.UtcNow.AddMinutes(options.Value.ExpirationInMinutes),
            signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
        );

        return handler.WriteToken(token);
    }
}
