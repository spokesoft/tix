namespace Tix.Domain.Entities;

public class Label : AuditableEntity<long>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}