namespace Tix.Domain.Entities;

public class Ticket
{
    public string? Name { get; set; }
    public string? Description { get; set; }

    public long ProjectId { get; set; }
    public virtual Project Project { get; set; } = null!;
}