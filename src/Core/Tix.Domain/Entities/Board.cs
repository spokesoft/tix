namespace Tix.Domain.Entities;

public class Board : AuditableEntity<long> 
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}