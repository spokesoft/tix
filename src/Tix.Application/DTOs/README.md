# Directory Structure

## 🗁 `src/Tix.Application/DTOs`

```
DTOs/
├── Common/                # Stuff used everywhere
├── Entities/              # Entity-specific DTOs
│   ├── Project/           # Project-related DTOs
│   ├── Ticket/            # Ticket-related DTOs
│   ├── Comment/           # Comment-related DTOs
│   └── User/              # User-related DTOs
```

### 🗀 [Common]

Shared DTO classes. Pagination results and whatnot.

### 🗀 [Entities]

DTOs for specific entities.

[common]: /src/Tix.Application/DTOs/Common/
[entities]: /src/Tix.Application/DTOs/Entities/