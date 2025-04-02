namespace Tix.Domain.Exceptions.Iteration;

public class DuplicateIterationException(long id) : DuplicateException(nameof(Iteration), $"{id}")
{
    public long Id { get; init; } = id;
}