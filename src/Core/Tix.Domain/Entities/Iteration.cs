namespace Tix.Domain.Entities;

public class Iteration : AuditableEntity<long>
{
    #region Properties

    public string? Name { get; set; }
    public string? Description { get; set; }
    public long ProjectId { get; set; }

    #endregion

    #region Navigation Properties

    public Project Project { get; set; } = null!;
    
    #endregion
}