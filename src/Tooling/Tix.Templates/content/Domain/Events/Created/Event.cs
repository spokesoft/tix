using Tix.Domain.Entities;

namespace Tix.Domain.Events.GenericEntity;

public class GenericEntityCreated : DomainEvent<GenericEntity>
{
    public GenericEntity? GenericEntity { get; set; }
}