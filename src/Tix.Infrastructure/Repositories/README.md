# Directory Structure

## 🗁 `src/Tix.Infrastructure/Repositories`

```
Repositories/
├── ProjectRepository.cs      # Project database access
├── TicketRepository.cs       # Ticket database access  
├── UserRepository.cs         # User database access
├── CommentRepository.cs      # Comment database access
└── TimeEntryRepository.cs    # Time entry database access
```

### 🖹 `ProjectRepository.cs`

Implements IProjectRepository. Mostly just calls DbContext with extra steps.

### 🖹 `TicketRepository.cs`

The complicated one. Probably has custom queries with five joins.

### 🖹 `UserRepository.cs`

User database access. Try not to look at how passwords are handled.

### 🖹 `CommentRepository.cs`

Comment database access. Hopefully eager-loads related entities.

### 🖹 `TimeEntryRepository.cs`

Time tracking repository. No doubt has complex reporting queries no one will use.

## 📝 Notes

This file is meant to be informative. The directory structure is accurate, but the files listed may be examples only.