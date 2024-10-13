namespace Identity.Shared.Models;

public class JWTOptions
{
    public required string Issuer {get; set;}
    public required string Audience {get; set;}
    public int ExpirationInMinutes {get; set;}
    public required string Key {get; set;}
    public int RefreshExpirationInDays {get; set;}
}
