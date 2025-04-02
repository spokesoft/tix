using Tix.Domain.Entities;

namespace Tix.Domain.Events.GenericEntity;

public class GenericEntityRestored : DomainEvent<GenericEntity>
{
    public GenericEntity? GenericEntity { get; set; }
}