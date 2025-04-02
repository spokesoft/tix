namespace Tix.Domain.Exceptions.Board;

public class BoardNotFoundException(long id) : NotFoundException(nameof(Board), $"{id}")
{
    public long Id { get; init; } = id;
}