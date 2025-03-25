# Application Tests

Tests for services that might work.

## Contents

```
Tix.Application.Tests/
├── Services/      # Service tests
├── Validators/    # Validator tests
└── Fixtures/  # Shared test setup
```

## Running

```
dotnet test Tix.Tests/Tix.Application.Tests
```

## Mocking

Interfaces mocked with whatever package was trending on GitHub.

## Guidelines

Services should do something. Tests should verify that.