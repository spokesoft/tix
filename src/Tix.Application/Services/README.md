# Directory Structure

## 🗁 `src/Tix.Application/Services`

```
Services/
├── ProjectService.cs      # Does project things
├── TicketService.cs       # Does ticket things  
├── UserService.cs         # Does user things
├── CommentService.cs      # Does comment things
└── TimeEntryService.cs    # Tracks time, probably
```

### 🖹 ProjectService.cs

Creates projects, lists projects, updates projects. Project stuff.

### 🖹 TicketService.cs

The important one. Tickets are the whole point, right?

### 🖹 UserService.cs

User creation, authentication, etc. Don't store passwords in plain text.

### 🖹 CommentService.cs

Adds comments to tickets. Basically just text with a timestamp.

### 🖹 TimeEntryService.cs

Tracks how long things take. Always longer than estimated.

## 📝 Notes

This file is meant to be informative. The directory structure is accurate, but the files listed may be examples only.
