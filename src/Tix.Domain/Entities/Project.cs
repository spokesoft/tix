using Tix.Domain.Interfaces;

namespace Tix.Domain.Entities;

public class Project : AuditableEntity<long>, IArchivable
{
    #region Properties

    public string Code { get; set; } = string.Empty;
    public string? Name { get; set; }
    public string? Description { get; set; }

    #endregion
    #region IArchivable Implementation

    public DateTime? ArchivedAt { get; set; }

    public long? ArchivedById { get; set; }
    public User? ArchivedBy { get; set; }

    public bool IsArchived => ArchivedAt.HasValue;

    #endregion
    #region Navigation Properties

    protected IList<Sequence> _sequences { get; set; } = [];
    protected IList<Ticket> _tickets { get; set; } = [];
    protected IList<Iteration> _iterations { get; set; } = [];
    protected IList<Board> _boards { get; set; } = [];
    protected IList<ProjectComment> _comments { get; set; } = [];
    protected IList<ProjectMember> _members { get; set; } = [];
    protected IList<Label> _labels { get; set; } = [];

    public IReadOnlyCollection<Sequence> Sequences => _sequences.AsReadOnly();
    public IReadOnlyCollection<ProjectMember> Members => _members.AsReadOnly();
    public IReadOnlyCollection<Ticket> Tickets => _tickets.AsReadOnly();
    public IReadOnlyCollection<Label> Labels => _labels.AsReadOnly();
    public IReadOnlyCollection<ProjectComment> Comments => _comments.AsReadOnly();
    public IReadOnlyCollection<Iteration> Iterations => _iterations.AsReadOnly();
    public IReadOnlyCollection<Board> Boards => _boards.AsReadOnly();

    #endregion
    #region Constructors

    private Project() { }

    public Project(string code, string? name, string? description)
    {
        Code = code;
        Name = name;
        Description = description;
    }

    #endregion
    #region Methods

    public void Update(string? code, string? name, string? description)
    {
        if (IsDeleted)
            throw new InvalidOperationException("Cannot update a deleted project");
        
        if (IsArchived)
            throw new InvalidOperationException("Cannot update a archived project");

        if (!string.IsNullOrEmpty(code))
        {

        }

        if (!string.IsNullOrEmpty(name))
        {
            Name = name;
        }

        if (!string.IsNullOrEmpty(description))
        {
            Description = description;
        }
    }

    #endregion
}