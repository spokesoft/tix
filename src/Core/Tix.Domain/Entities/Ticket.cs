namespace Tix.Domain.Entities;

public class Ticket : AuditableEntity<long>
{
    public long ProjectId { get; private set; }
    public Project Project { get; private set; } = null!;
    public string DisplayName { get; set; } = string.Empty;
}