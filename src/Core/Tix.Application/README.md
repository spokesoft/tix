# Directory Structure

## 🗁 `src/Tix.Application`

```
Tix.Application/
├── Commands/       # Changing things (the C in CQRS)
├── DTOs/           # Data objects without behavior
├── Interfaces/     # More contracts
├── Queries/        # Getting things (the Q in CQRS)
├── Services/       # For anyone who didn't get the CQRS memo
└── Validators/     # Occasionally prevent bad data
```

### 🗀 [Commands]

For when you want to make something happen. Creating, updating, deleting.

### 🗀 [DTOs]

Domain objects on vacation. No behavior allowed.

### 🗀 [Interfaces]

Contracts with Infrastructure. Promises we hope will be kept.

### 🗀 [Queries]

For when you want to know things. Getting, listing, searching.

### 🗀 [Services]

Where CQRS actually happens. Or convenience wrappers around Commands/Queries. Sometimes both.

### 🗀 [Validators]

Making sure garbage doesn't get in. Sometimes succeeds.

## 📝 Notes

This file is meant to be informative. The directory structure is accurate, but the files listed may be examples only.

## Guidelines

Don't reference Infrastructure here. 

## Dependencies

- Tix.Domain
- Whatever NuGet packages seemed useful at the time

[commands]: /src/Tix.Application/Commands/
[dtos]: /src/Tix.Application/DTOs/
[interfaces]: /src/Tix.Application/Interfaces/
[queries]: /src/Tix.Application/Queries/
[services]: /src/Tix.Application/Services/
[validators]: /src/Tix.Application/Validators/