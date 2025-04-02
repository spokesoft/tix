namespace Tix.Domain.Exceptions.Iteration;

public class IterationNotFoundException(long id) : NotFoundException(nameof(Iteration), $"{id}")
{
    public long Id { get; init; } = id;
}