namespace Tix.Domain.Entities;

public class Team : AuditableEntity<long>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}