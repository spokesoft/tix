namespace Tix.Domain.Entities;

public class Member : AuditableEntity<long>
{
    public required string Content { get; set; }
    public virtual IEnumerable<ReplyComment> Replies { get; set; } = [];
}

public class OrganizationMember : Comment
{
    public long OrganizationId { get; set; }
    public virtual Organization Organization { get; set; } = null!;
}

public class TeamMember : Comment
{
    public long TeamId { get; set; }
    public virtual Team Team { get; set; } = null!;
}

public class ProjectMember : Comment
{
    public long ProjectId { get; set; }
    public virtual Project Project { get; set; } = null!;
}