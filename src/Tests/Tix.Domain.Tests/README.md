# Domain Tests

Tests for core business objects.

## Contents

```
Tix.Domain.Tests/
├── Entities/      # Entity behavior tests
├── Events/        # Event tests
└── Utils/         # Test helpers
```

## Running

```
dotnet test Tix.Tests/Tix.Domain.Tests
```

## Guidelines

Test business rules, not getters and setters.