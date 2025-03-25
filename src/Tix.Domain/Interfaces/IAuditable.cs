using Tix.Domain.Entities;

namespace Tix.Domain.Interfaces;

public interface IAuditable
{
    DateTime CreatedAt { get; set; }
    DateTime UpdatedAt { get; set; }
    DateTime? DeletedAt { get; set; }
    long CreatedById { get; set; }
    long UpdatedById { get; set; }
    long? DeletedById { get; set; }
    User CreatedBy { get; set; }
    User UpdatedBy { get; set; }
    User? DeletedBy { get; set; }
}

public interface IAuditable<TId> : IAuditable, IKeyedEntity<TId> {}