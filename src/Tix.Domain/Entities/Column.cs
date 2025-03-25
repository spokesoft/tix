namespace Tix.Domain.Entities;

public class Column : AuditableEntity<long>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}