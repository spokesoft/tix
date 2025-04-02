# Queries

Where data comes to be retrieved, not changed.

## What Are These?

CQRS queries. The "Q" part of the pattern that handles all the read operations.

## Rules of Query Club

1. Queries retrieve data. They never modify state.
2. Queries are named descriptively. `GetTicketById`, not `RetrieveTicket`.
3. Queries always return something, even if it's just an empty collection.

## Directory Structure

```
Queries/
├── Organization/
│   ├── GetOrganizationById.cs
│   ├── GetOrganizationByIdHandler.cs
│   ├── ListOrganizations.cs
│   └── ListOrganizationsHandler.cs
├── Project/
│   └── etc...
└── README.md     # You are here.
```

## Example

```csharp
// Query
public class GetTicketById : IQuery
{
    // Data needed to find the thing
}

// Handler
public class GetTicketByIdHandler 
    : IQueryHandler<GetTicketById, TicketDto>
{
    // Handle the query
}
```

## FAQ

**Q: Can my query change data?**  
A: No. That's what Commands are for. It's like expecting a thermometer to change the temperature.

**Q: Can queries have side effects?**  
A: No. Not even logging (beyond system logging). Queries should be pure.

**Q: Should queries be cached?**  
A: Often, yes. Unlike commands, queries are great candidates for caching.

**Q: Why CQRS?**  
A: Because different optimization strategies for reads and writes make your application more scalable.