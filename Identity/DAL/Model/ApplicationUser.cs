namespace Identity.DAL.Model;

public class ApplicationUser : IdentityUser, IAggregate
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? OTP { get; set; }
    public string? OTPExpireDate { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpireDate { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? DeletedBy { get; set; }
    public DateTime? DeletedDate { get; set; }

    [NotMapped]
    private readonly List<IDomainEvent> _domainEvents = [];
    [NotMapped]
    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
    
    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public IDomainEvent[] ClearDomainEvents()
    {
        var domainEvents = _domainEvents.ToArray();
        _domainEvents.Clear();
        return domainEvents;
    }
}
