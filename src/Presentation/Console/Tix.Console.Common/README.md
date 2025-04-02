# Console

Command-line interface. The only project users might see.

## Contents

```
Tix.Console/
├── Commands/     # Various commands nobody remembers
├── Views/        # Terminal output formatters
├── Extensions/   # Helper methods
├── Program.cs    # Entry point
└── Startup.cs    # Configuration
```

## How to Run

```
dotnet run
```

Or install globally:

```
dotnet tool install -g --add-source ./nupkg Tix
```

## Dependencies

- Tix.Application
- Tix.Infrastructure
- Spectre.Console
- Other CLI packages