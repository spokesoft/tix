namespace Tix.Generator.Models;

/// <summary>
/// Contains information about a relationship between entities
/// </summary>
public class RelationshipInfo
{
    /// <summary>
    /// The name of the navigation property
    /// </summary>
    public string PropertyName { get; set; } = string.Empty;

    /// <summary>
    /// The name of the related entity
    /// </summary>
    public string RelatedEntityName { get; set; } = string.Empty;

    /// <summary>
    /// Indicates whether this is a collection relationship (one-to-many or many-to-many)
    /// </summary>
    public bool IsCollection { get; set; }

    /// <summary>
    /// The name of the foreign key property
    /// </summary>
    public string? ForeignKeyProperty { get; set; }
}