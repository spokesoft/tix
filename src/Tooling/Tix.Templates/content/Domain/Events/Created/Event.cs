namespace Tix.Domain.Events.GenericEntity;

public class GenericEntityCreated(long id) : DomainEvent
{
    public long GenericEntityId { get; init; } = id;
}