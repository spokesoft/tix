# Directory Structure

## 🗁 `src/Tix.Application/Interfaces`

```
Interfaces/
├── Repositories/     # Database contracts
│   ├── IProjectRepository.cs
│   ├── ITicketRepository.cs
│   ├── IUserRepository.cs
│   ├── ICommentRepository.cs
│   └── ITimeEntryRepository.cs
├── Services/         # External service contracts
│   ├── IEmailService.cs
│   ├── IAuthenticationService.cs
│   └── IStorageService.cs
└── Infrastructure/   # Other infrastructure contracts
    ├── IUnitOfWork.cs
    └── IDateTimeProvider.cs
```

### 🗀 [Repositories]

Database access contracts. No SQL allowed, just method signatures.

### 🗀 [Services]

Contracts for things that aren't databases.

### 🗀 [Infrastructure]

Miscellaneous plumbing interfaces.

## 📝 Notes 

This file is meant to be informative. The directory structure is accurate, but the files listed may be examples only.

[Repositories]: /src/Tix.Application/Interfaces/Repositories/
[Services]: /src/Tix.Application/Interfaces/Services/
[Infrastructure]: /src/Tix.Application/Interfaces/Infrastructure/