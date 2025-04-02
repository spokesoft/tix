# Commands

CLI commands for Tix.

## Structure

```
Commands/
├── Project/     # Project management
│   ├── CreateProjectCommand.cs
│   ├── ListProjectsCommand.cs
│   └── DeleteProjectCommand.cs
├── Ticket/      # Ticket operations
│   ├── CreateTicketCommand.cs
│   ├── UpdateTicketCommand.cs
│   └── ListTicketsCommand.cs
└── User/        # User management
    └── etc...
```

## Adding Commands

1. Create class
2. Inherit from Command\<T>
3. Register in Program.cs
4. Forget to document

## Guidelines

Keep commands simple. Commands should dispatch to Application layer Commands for writes and Queries for reads.