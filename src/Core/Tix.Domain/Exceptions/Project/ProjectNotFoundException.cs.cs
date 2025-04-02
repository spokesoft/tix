namespace Tix.Domain.Exceptions.Project;

public class ProjectNotFoundException(long id) : NotFoundException(nameof(Project), $"{id}")
{
    public long Id { get; init; } = id;
}