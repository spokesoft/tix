namespace Tix.Domain.Exceptions.Column;

public class DuplicateColumnException(long id) : DuplicateException(nameof(Column), $"{id}")
{
    public long Id { get; init; } = id;
}