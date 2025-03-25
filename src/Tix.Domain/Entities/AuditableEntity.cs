using Tix.Domain.Interfaces;

namespace Tix.Domain.Entities;

public class AuditableEntity : Entity, IAuditable
{
    public DateTime CreatedAt { get ; set; }
    public DateTime UpdatedAt { get ; set; }
    public DateTime? DeletedAt { get ; set; }

    public long CreatedById { get ; set; }
    public User CreatedBy { get ; set; } = null!;

    public long UpdatedById { get ; set; }
    public User UpdatedBy { get ; set; } = null!;

    public long? DeletedById { get ; set; }
    public User? DeletedBy { get ; set; }

    public bool IsUpdated => UpdatedAt > CreatedAt;
    public bool IsDeleted => DeletedAt.HasValue;
}

public abstract class AuditableEntity<TId> : AuditableEntity, IAuditable<TId>
{
    public TId Id { get ; set; } = default!;
}