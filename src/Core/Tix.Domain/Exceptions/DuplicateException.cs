namespace Tix.Domain.Exceptions;

public class DuplicateException(string type, string id) 
    : DomainException($"{type} with primary key [{id}] already exists.")
{

}

public class DuplicateException<T>(string id) : NotFoundException(nameof(T), id)
{
    
}