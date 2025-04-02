namespace Tix.Domain.Exceptions.Sequence;

public class DuplicateSequenceException(long id) : DuplicateException(nameof(Sequence), $"{id}")
{
    public long Id { get; init; } = id;
}