# Domain

Core business objects that pretend to have no dependencies.

## Contents

```
Tix.Domain/
├── Entities/      # Things with IDs
├── Enums/         # Glorified integers
├── Events/        # Things nobody subscribes to
├── Exceptions/    # Custom ways to crash
└── Interfaces/    # Contracts nobody honors
```

## Guidelines

Keep this project clean. No dependencies except System.*

## Examples

```csharp
// Just look at the files
```