namespace Tix.Domain.Events.{{ name }};

public class {{ name }}DeletedHandler : DomainEventHandler<{{ name }}Deleted>
{
    public override void Handle({{ name }}Deleted ev)
    {
        // TODO: Handle event
    }
}