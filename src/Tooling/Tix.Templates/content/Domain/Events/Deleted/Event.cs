using Tix.Domain.Entities;

namespace Tix.Domain.Events.GenericEntity;

public class GenericEntityDeleted : DomainEvent<GenericEntity>
{
    public GenericEntity? GenericEntity { get; set; }
}