namespace Tix.Domain.Exceptions.Column;

public class ColumnNotFoundException(long id) : NotFoundException(nameof(Column), $"{id}")
{
    public long Id { get; init; } = id;
}