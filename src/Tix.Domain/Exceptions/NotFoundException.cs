namespace Tix.Domain.Exceptions;

public class DuplicateException : Exception
{

}

public class DuplicateException<T> : DuplicateException
{
    
}