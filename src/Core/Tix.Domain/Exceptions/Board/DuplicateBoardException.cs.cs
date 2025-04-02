namespace Tix.Domain.Exceptions.Board;

public class DuplicateBoardException(long id) : DuplicateException(nameof(Board), $"{id}")
{
    public long Id { get; init; } = id;
}