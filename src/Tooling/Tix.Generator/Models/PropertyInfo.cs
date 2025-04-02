namespace Tix.Generator.Models;

/// <summary>
/// Contains information about a property for templating purposes
/// </summary>
public class PropertyInfo
{
    /// <summary>
    /// The name of the property
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The type of the property in a friendly format (e.g., "DateTime" not "System.DateTime")
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Indicates whether the property is nullable
    /// </summary>
    public bool IsNullable { get; set; } = false;

    /// <summary>
    /// Indicates whether the property is a collection type
    /// </summary>
    public bool IsCollection { get; set; } = false;

    /// <summary>
    /// If the property is a collection, this is the element type (e.g., "Customer" for IList<Customer>)
    /// </summary>
    public string? ElementType { get; set; }
}