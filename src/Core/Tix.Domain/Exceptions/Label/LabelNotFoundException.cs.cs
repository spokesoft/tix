namespace Tix.Domain.Exceptions.Label;

public class LabelNotFoundException(long id) : NotFoundException(nameof(Label), $"{id}")
{
    public long Id { get; init; } = id;
}