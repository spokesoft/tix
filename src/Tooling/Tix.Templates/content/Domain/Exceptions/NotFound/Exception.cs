namespace Tix.Domain.Exceptions.GenericEntity;

public class GenericEntityNotFoundException(long id) : NotFoundException(nameof(GenericEntity), $"{id}")
{
    public long Id { get; init; } = id;
}