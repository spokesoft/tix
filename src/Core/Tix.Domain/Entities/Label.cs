namespace Tix.Domain.Entities;

public class Label : AuditableEntity<long>
{
    #region Properties

    public string? Name { get; set; }
    public string? Description { get; set; }

    #endregion
}