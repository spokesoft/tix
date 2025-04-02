using Tix.Domain.Entities;

namespace Tix.Domain.Interfaces;

public interface IAuditable
{
    DateTime CreatedAt { get; }
    DateTime UpdatedAt { get; }
    DateTime? DeletedAt { get; }
    long CreatedById { get; }
    long UpdatedById { get; }
    long? DeletedById { get; }
    User CreatedBy { get; }
    User UpdatedBy { get; }
    User? DeletedBy { get; }
}

public interface IAuditable<TId> : IAuditable, IKeyedEntity<TId> {}