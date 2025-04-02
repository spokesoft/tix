using System.Reflection;
using Tix.Domain.Interfaces;
using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

/// <summary>
/// Provides information about entity types in the domain layer
/// </summary>
public class SourceCodeService : ISourceCodeService
{
    private readonly string _domainAssemblyPath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "Tix.Domain.dll");

    /// <summary>
    /// Gets all entities from the domain assembly
    /// </summary>
    /// <returns>A collection of EntityInfo objects representing the domain entities</returns>
    public IEnumerable<EntityInfo> GetAllEntities()
    {
        // Load the domain assembly
        Assembly domainAssembly = Assembly.LoadFrom(_domainAssemblyPath);

        // Get all types that implement IEntity
        var entityTypes = domainAssembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && typeof(IEntity).IsAssignableFrom(t));

        // Create a dictionary of all entity names for relationship detection
        var entityNames = entityTypes.ToDictionary(t => t.Name, t => t);

        // Create EntityInfo objects for each entity type
        foreach (var entityType in entityTypes)
        {
            var properties = entityType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var entityInfo = new EntityInfo
            {
                Name = entityType.Name,
                FullName = entityType?.FullName ?? "FakeEntityName",
                ReadableProperties = GetReadableProperties(properties, entityNames),
                WritableProperties = GetWritableProperties(properties, entityNames),
                Relationships = GetRelationships(properties, entityNames)
            };

            yield return entityInfo;
        }
    }

    private static IEnumerable<Models.PropertyInfo> GetReadableProperties(
        IEnumerable<System.Reflection.PropertyInfo> properties,
        Dictionary<string, Type> entityNames)
    {
        return properties
            .Where(p => p.CanRead && !IsRelationshipProperty(p, entityNames))
            .Select(p => CreatePropertyInfo(p));
    }

    private static IEnumerable<Models.PropertyInfo> GetWritableProperties(
        IEnumerable<System.Reflection.PropertyInfo> properties,
        Dictionary<string, Type> entityNames)
    {
        return properties
            .Where(p => p.CanWrite &&
                        p.SetMethod != null &&
                        p.SetMethod.IsPublic &&
                        !IsRelationshipProperty(p, entityNames))
            .Select(CreatePropertyInfo);
    }

    private static IEnumerable<RelationshipInfo> GetRelationships(
        IEnumerable<System.Reflection.PropertyInfo> properties,
        Dictionary<string, Type> entityNames)
    {
        var relationships = new List<RelationshipInfo>();
        var possibleRelations = new Dictionary<string, System.Reflection.PropertyInfo>();

        // First pass: collect all possible foreign keys
        foreach (var property in properties)
        {
            if (property.Name.EndsWith("Id") && property.PropertyType == typeof(int) ||
                property.PropertyType == typeof(Guid) ||
                property.PropertyType == typeof(long))
            {
                possibleRelations.Add(property.Name, property);
            }
        }

        // Second pass: find navigation properties
        foreach (var property in properties)
        {
            // Check if this is a navigation property
            var propertyType = property.PropertyType;

            if (IsCollectionType(propertyType))
            {
                // Handle collection navigation (one-to-many or many-to-many)
                var elementType = GetElementType(propertyType);
                if (elementType != null && entityNames.ContainsKey(elementType.Name))
                {
                    relationships.Add(new RelationshipInfo
                    {
                        PropertyName = property.Name,
                        RelatedEntityName = elementType.Name,
                        IsCollection = true,
                        ForeignKeyProperty = GetForeignKeyName(elementType.Name, property.DeclaringType?.Name)
                    });
                }
            }
            else if (entityNames.ContainsKey(propertyType.Name))
            {
                // Handle single navigation property (many-to-one or one-to-one)
                string foreignKeyName = $"{propertyType.Name}Id";
                if (possibleRelations.ContainsKey(foreignKeyName))
                {
                    relationships.Add(new RelationshipInfo
                    {
                        PropertyName = property.Name,
                        RelatedEntityName = propertyType.Name,
                        IsCollection = false,
                        ForeignKeyProperty = foreignKeyName
                    });
                }
            }
        }

        return relationships;
    }

    private static string? GetForeignKeyName(string relatedEntityName, string? declaringTypeName)
    {
        // Try to determine the likely foreign key name
        if (string.IsNullOrEmpty(declaringTypeName))
            return null;

        return $"{declaringTypeName}Id";
    }

    private static bool IsRelationshipProperty(System.Reflection.PropertyInfo property, Dictionary<string, Type> entityNames)
    {
        // Check if this is a foreign key property
        if (property.Name.EndsWith("Id") && (
            property.PropertyType == typeof(int) ||
            property.PropertyType == typeof(Guid) ||
            property.PropertyType == typeof(long)))
        {
            string possibleEntityName = property.Name[..^2];
            return entityNames.ContainsKey(possibleEntityName);
        }

        // Check if this is a navigation property
        var propertyType = property.PropertyType;

        if (IsCollectionType(propertyType))
        {
            var elementType = GetElementType(propertyType);
            return elementType != null && entityNames.ContainsKey(elementType.Name);
        }

        return entityNames.ContainsKey(propertyType.Name);
    }

    private static Models.PropertyInfo CreatePropertyInfo(System.Reflection.PropertyInfo property)
    {
        return new Models.PropertyInfo
        {
            Name = property.Name,
            Type = GetFriendlyTypeName(property.PropertyType),
            IsNullable = IsNullableType(property.PropertyType),
            IsCollection = IsCollectionType(property.PropertyType),
            ElementType = GetElementTypeName(property.PropertyType)
        };
    }

    private static string GetFriendlyTypeName(Type type)
    {
        // Handle nullable value types
        if (IsNullableType(type))
        {
            Type underlyingType = Nullable.GetUnderlyingType(type) ?? throw new ArgumentNullException(nameof(type));
            return GetFriendlyTypeName(underlyingType);
        }

        // Handle collection types
        if (IsCollectionType(type))
        {
            Type elementType = GetElementType(type) ?? throw new ArgumentNullException(nameof(type));
            string elementTypeName = elementType != null ? GetFriendlyTypeName(elementType) : "object";

            // Determine the collection type name
            if (type.IsArray)
            {
                return $"{elementTypeName}[]";
            }

            if (type.IsGenericType)
            {
                string collectionName = type.GetGenericTypeDefinition().Name;
                // Remove the generic arity (`1, `2, etc.)
                collectionName = collectionName.Split('`')[0];
                return $"{collectionName}<{elementTypeName}>";
            }

            return $"IEnumerable<{elementTypeName}>";
        }

        // Use mapped names for common types
        return type.Name switch
        {
            "String" => "string",
            "Int32" => "int",
            "Boolean" => "bool",
            "Decimal" => "decimal",
            "Double" => "double",
            "Single" => "float",
            "Int64" => "long",
            "Int16" => "short",
            "Byte" => "byte",
            "Char" => "char",
            "Object" => "object",
            "Void" => "void",
            "DateTime" => "DateTime",
            "Guid" => "Guid",
            "TimeSpan" => "TimeSpan",
            // Add more mappings as needed
            _ => type.Name // Use the type name as is for other types
        };
    }

    private static bool IsNullableType(Type type)
    {
        return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
    }

    private static bool IsCollectionType(Type type)
    {
        // Check if the type is a collection (array, list, etc.)
        return type.IsArray ||
               (type.IsGenericType && typeof(IEnumerable<>).IsAssignableFrom(type.GetGenericTypeDefinition())) ||
               typeof(System.Collections.IEnumerable).IsAssignableFrom(type) && type != typeof(string);
    }

    private static Type? GetElementType(Type? type)
    {
        if (type == null) return null;

        // Get the element type of a collection
        if (type.IsArray)
        {
            return type.GetElementType();
        }

        if (type.IsGenericType && type.GetGenericArguments().Length > 0)
        {
            return type.GetGenericArguments()[0];
        }

        return null;
    }

    private static string? GetElementTypeName(Type type)
    {
        Type? elementType = GetElementType(type);
        return elementType != null ? GetFriendlyTypeName(elementType) : null;
    }

    public Task<bool> ExistsAsync(string path)
    {
        throw new NotImplementedException();
    }
}