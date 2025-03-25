# Directory Structure

## 🗁 `src/Tix.Infrastructure/Configurations`

```
Configurations/
├── ProjectConfiguration.cs      # Project table setup
├── TicketConfiguration.cs       # Ticket table setup
├── UserConfiguration.cs         # User table setup
├── CommentConfiguration.cs      # Comment table setup
└── TimeEntryConfiguration.cs    # Time entry table setup
```

### 🖹 `ProjectConfiguration.cs`

Defines Project entity → table mapping. Fluent API gone wild.

### 🖹 `TicketConfiguration.cs`

The most complex one. Foreign keys everywhere. Probably has a self-reference.

### 🖹 `UserConfiguration.cs`

Sets up the User table. Hopefully encrypts passwords properly.

### 🖹 `CommentConfiguration.cs`

Comment table configuration. Text columns with max length that's either too small or ridiculously large.

### 🖹 `TimeEntryConfiguration.cs`

Time tracking configuration. Decimal(18,2) for hours because someone's afraid of rounding errors.

## 📝 Notes

This file is meant to be informative. The directory structure is accurate, but the files listed may be examples only.