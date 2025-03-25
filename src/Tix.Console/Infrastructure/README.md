# Directory Structure

## 🗁 `src/Tix.Console/Infrastructure`

```
Infrastructure/
├── TypeRegistrar.cs      # Spectre.Console DI integration
├── TypeResolver.cs       # For finding commands and stuff
└── VersionHelper.cs      # Figures out what version we're running
```

### 🖹 `TypeRegistrar.cs`

Connects Spectre.Console to our DI container. Copy-pasted from their docs.

### 🖹 `TypeResolver.cs`

Finds types at runtime so we don't have to register commands manually.

### 🖹 `VersionHelper.cs`

Gets the assembly version. One method that saves like 3 lines of code.

## 📝 Notes 

This file is meant to be informative. The directory structure is accurate, but the files listed may be examples only.