# Directory Structure

## ./src

```
src/
├── Tix.Domain/            # Contains entities and stuff
├── Tix.Application/       # Has services, probably
├── Tix.Infrastructure/    # Database and whatever
├── Tix.Console/           # Command-line interface
└── Tix.Tests/             # Tests, if we write any
```

### Tix.Domain

Business objects. Tickets and projects or something.

### Tix.Application

Services that do things with domain objects.

### Tix.Infrastructure

Database access and external dependencies.

### Tix.Console

Commands and terminal output.

### Tix.Tests

Might contain tests someday.