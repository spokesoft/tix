namespace Tix.Domain.Exceptions.Sequence;

public class SequenceNotFoundException(long id) : NotFoundException(nameof(Sequence), $"{id}")
{
    public long Id { get; init; } = id;
}