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
dotnet test Tix.Tests/Tix.Infrastructure.Postgres.Tests
```

## Guidelines

Use Postgres in-memory when possible.