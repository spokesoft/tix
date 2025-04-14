namespace Tix.Domain.Entities;

public class Column : AuditableEntity<long>
{
    #region Properties

    public string? Name { get; set; }
    public string? Description { get; set; }
    public long BoardId { get; set; }

    #endregion

    #region Navigation Properties

    protected IList<Ticket> _tickets { get; set; } = [];

    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();

    #endregion
}