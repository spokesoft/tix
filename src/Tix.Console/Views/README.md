# Views

Terminal output formatters using Spectre.Console.

## Contents

```
Views/
├── ProjectView.cs    # Project rendering
├── TicketView.cs     # Ticket display
└── ReportView.cs     # Report formatting
```

## Usage

```csharp
// Call from commands
ProjectView.Render(project);
```

## Guidelines

Keep logic out. Format data only.