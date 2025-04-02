namespace Tix.Domain.Exceptions.Label;

public class DuplicateLabelException(long id) : DuplicateException(nameof(Label), $"{id}")
{
    public long Id { get; init; } = id;
}