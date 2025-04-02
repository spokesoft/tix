# Infrastructure

Data access and other implementation details.

## Contents

```
Tix.Infrastructure/
├── Configurations/ # EF Core mapping rules
├── Data/           # Database contexts
├── Identity/       # Auth stuff
├── Migrations/     # EF wanted these
└── Repositories/   # CRUD operations
```

## Setup

Configure connection string somewhere.

## Dependencies

- Tix.Domain
- Tix.Application
- Entity Framework
- SQLite
- Other packages we'll regret later