namespace Tix.Domain.Events.GenericEntity;

public class GenericEntityArchived(long id) : DomainEvent
{
    public long GenericEntityId { get; init; } = id;
}