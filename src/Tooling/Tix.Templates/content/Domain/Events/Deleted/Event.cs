namespace Tix.Domain.Events.GenericEntity;

public class GenericEntityDeleted(long id) : DomainEvent
{
    public long GenericEntityId { get; init; } = id;
}