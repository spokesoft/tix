namespace Tix.Domain.Exceptions;

public class NotFoundException(string type, string id) 
    : DomainException($"{type} with primary key [{id}] was not found.")
{

}

public class NotFoundException<T, TId>(TId id) : NotFoundException(nameof(T), id?.ToString() ?? "") {}