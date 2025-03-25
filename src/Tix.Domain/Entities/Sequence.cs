namespace Tix.Domain.Entities;

public class Sequence : AuditableEntity<long>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public long Value { get; set; } = 0;
    public required string Template { get; set; }

    public long? ProjectId { get; set; }
    public virtual Project? Project { get; set; }
}