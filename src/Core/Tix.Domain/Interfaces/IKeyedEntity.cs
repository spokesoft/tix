namespace Tix.Domain.Interfaces;

public interface IKeyedEntity : IEntity {}

public interface IKeyedEntity<TId> : IKeyedEntity
{
    TId Id { get; }
}