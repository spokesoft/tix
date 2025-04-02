# Console Tests

Tests for CLI commands that might run.

## Contents

```
Tix.Console.Tests/
├── Commands/     # Command tests
├── Views/        # Output formatter tests
└── Fixtures/     # Test helpers
```

## Running

```
dotnet test Tix.Tests/Tix.Console.Tests
```

## Approach

Commands tested without actually running them.

## Guidelines

Test command execution not terminal output.