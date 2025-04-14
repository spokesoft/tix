namespace Tix.Domain.Entities;

public class Board : AuditableEntity<long>
{
    #region Properties

    public string? Name { get; set; }
    public string? Description { get; set; }
    public long ProjectId { get; set; }

    #endregion

    #region Navigation Properties

    protected IList<Column> _columns { get; set; } = [];

    public Project Project { get; set; } = null!;
    public IEnumerable<Column> Columns => _columns.AsReadOnly();

    #endregion
}