namespace Tix.Domain.Events;

public abstract class DomainEvent(string entityType, long entityId)
{
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime OccurredAt { get; } = DateTime.UtcNow;
    public string EntityType { get; } = entityType;
    public long EntityId { get; } = entityId;
}