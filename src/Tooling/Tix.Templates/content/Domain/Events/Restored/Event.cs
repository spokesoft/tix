namespace Tix.Domain.Events.GenericEntity;

public class GenericEntityRestored(long id) : DomainEvent
{
    public long GenericEntityId { get; init; } = id;
}