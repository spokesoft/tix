namespace Tix.Domain.Interfaces;

public interface IKeyedEntity<TId>
{
    TId Id { get; set; }
}