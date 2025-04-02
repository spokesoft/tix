using Tix.Domain.Entities;

namespace Tix.Domain.Events.GenericEntity;

public class GenericEntityUpdated : DomainEvent<GenericEntity>
{
    public GenericEntity? GenericEntity { get; set; }
}