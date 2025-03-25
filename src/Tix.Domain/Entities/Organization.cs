namespace Tix.Domain.Entities;

public class Organization : AuditableEntity<long>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}