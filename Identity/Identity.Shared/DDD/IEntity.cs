namespace Identity.Shared.DDD;

public interface IEntity<T> : IEntity
{
    T Id { get; set; }
}

public interface IEntity
{
    string? CreatedBy { get; set; }
    DateTime? CreatedDate { get; set; }
    string? ModifiedBy { get; set; }
    DateTime? ModifiedDate { get; set; }
    string? DeletedBy { get; set; }
    DateTime? DeletedDate { get; set; }
}
