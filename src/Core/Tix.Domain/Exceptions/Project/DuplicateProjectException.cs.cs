namespace Tix.Domain.Exceptions.Project;

public class DuplicateProjectException(long id) : DuplicateException(nameof(Project), $"{id}")
{
    public long Id { get; init; } = id;
}