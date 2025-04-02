# Commands

Where state changes begin their journey.

## What Are These?

CQRS commands. The "C" part of the pattern that handles all the write operations.

## Rules of Command Club

1. Commands mutate state. They change things in your system.
2. Commands use imperative naming. `CreateTicket`, not `TicketCreation`.
3. Commands can fail. Proper error handling recommended.

## Folder Structure

```
Commands/
├── Organization/
│   ├── CreateOrganization.cs
│   ├── CreateOrganizationHandler.cs
│   ├── DeleteOrganization.cs
│   └── DeleteOrganizationHandler.cs
├── Project/
│   └── etc...
└── README.md     # You are here.
```

## Example

`Ticket/CreateTicket.cs`

```csharp
public class CreateTicket : ICommand
{
    // Data needed to create the ticket
    public string Title { get; }
    public string Description { get; }
    
    public CreateTicket(string title, string description)
    {
        Title = title; // Validation happens in the handler
        Description = description;
    }
}
```

`Ticket/CreateTicketHandler.cs`

```csharp
public class CreateTicket : ICommandHandler<CreateTicket>
{
    protected readonly IUnitOfWork _unitOfWork { get; set; }
    protected readonly ITicketRepository _tickets { get; set; }
    public async Task<int> HandleAsync(CreateTicket request)
    {
        // Handle the command
        await _unitOfWork.CommitAsync();
    }
}
```

## FAQ

**Q: Can my command return data?**  
A: No. That's what Queries are for. It's like expecting your vacuum cleaner to make coffee.

**Q: Can I put business logic in my command?**  
A: No. Commands are DTOs. Logic belongs in handlers.

**Q: Should I name my command `PerformActionX`?**  
A: Just `ActionX` will do. Verbs are already about performing things.

**Q: Why CQRS?**  
A: Because separation of concerns makes your code easier to maintain, test, and debug.