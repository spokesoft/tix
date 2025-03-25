# Infrastructure Tests

Tests for data access that probably use in-memory databases.

## Contents

```
Tix.Infrastructure.Tests/
├── Repositories/    # Repository tests
├── Data/            # Context tests
└── TestHelpers/     # Setup utilities
```

## Running

```
dotnet test Tix.Tests/Tix.Infrastructure.Tests
```

## Guidelines

Use SQLite in-memory when possible.