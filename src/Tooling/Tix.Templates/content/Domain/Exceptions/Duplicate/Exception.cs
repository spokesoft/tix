namespace Tix.Domain.Exceptions.GenericEntity;

public class DuplicateGenericEntityException(long id) : DuplicateException(nameof(GenericEntity), $"{id}")
{
    public long Id { get; init; } = id;
}