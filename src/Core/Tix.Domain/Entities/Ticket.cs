namespace Tix.Domain.Entities;

public class Ticket : AuditableEntity<long>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public long ProjectId { get; private set; }
    public Project Project { get; private set; } = null!;
}