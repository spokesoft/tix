using Tix.Domain.Interfaces;

namespace Tix.Domain.Entities;

public abstract class AuditableEntity : IAuditable
{
    public DateTime CreatedAt { get ; private set; }
    public DateTime UpdatedAt { get ; private set; }
    public DateTime? DeletedAt { get ; private set; }

    public long CreatedById { get ; private set; }
    public User CreatedBy { get ; private set; } = null!;

    public long UpdatedById { get ; private set; }
    public User UpdatedBy { get ; private set; } = null!;

    public long? DeletedById { get ; private set; }
    public User? DeletedBy { get ; private set; }

    public bool IsUpdated => UpdatedAt > CreatedAt;
    public bool IsDeleted => DeletedAt.HasValue;
}

public abstract class AuditableEntity<TId> : AuditableEntity, IAuditable<TId>
{
    public TId Id { get; private set; } = default!;
}