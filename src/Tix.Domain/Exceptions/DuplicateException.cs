namespace Tix.Domain.Exceptions;

public class NotFoundException : Exception
{

}

public class NotFoundException<T> : NotFoundException
{
    
}