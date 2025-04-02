namespace Tix.Domain.Events.GenericEntity;

public class GenericEntityUpdated(long id) : DomainEvent
{
    public long GenericEntityId { get; init; } = id;
}