namespace Tix.Domain.Events;

public abstract class DomainEventHandler
{

}

public abstract class DomainEventHandler<T> : DomainEventHandler where T : DomainEvent
{
    public abstract void Handle(T e);
}