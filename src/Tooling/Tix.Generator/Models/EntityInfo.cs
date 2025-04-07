namespace Tix.Generator.Models;

/// <summary>
/// Contains flat information about an entity
/// </summary>
public class EntityInfo
{
    /// <summary>
    /// The short name of the entity
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Type of the primary key
    /// </summary>
    public string PrimaryKeyType { get; set; } = string.Empty;

    /// <summary>
    /// The fully qualified name of the entity
    /// </summary>
    public string FullName { get; set; } = string.Empty;
    public string ClassName => FullName.Split('.').Last();
    public string Namespace => string.Join(".", FullName.Split('.').SkipLast(1));

    /// <summary>
    /// Properties that can be read (have getters)
    /// </summary>
    public IEnumerable<PropertyInfo> ReadableProperties { get; set; } = [];

    /// <summary>
    /// Properties that can be written (have setters)
    /// </summary>
    public IEnumerable<PropertyInfo> WritableProperties { get; set; } = [];

    /// <summary>
    /// Relationships to other entities
    /// </summary>
    public IEnumerable<RelationshipInfo> Relationships { get; set; } = [];

    /// <summary>
    /// Is entity archivable
    /// </summary>
    public bool IsArchivable { get; set; } = false;
}