using Tix.Domain.Entities;

namespace Tix.Domain.Events.GenericEntity;

public class GenericEntityArchived : DomainEvent<GenericEntity>
{
    public GenericEntity? GenericEntity { get; set; }
}