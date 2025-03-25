namespace Tix.Domain.Entities;

public class Comment : AuditableEntity<long>
{
    public required string Content { get; set; }
    public virtual IEnumerable<ReplyComment> Replies { get; set; } = [];
}

public class ReplyComment : Comment
{
    public long CommentId { get; set; }
    public virtual Comment Comment { get; set; } = null!;
}

public class ProjectComment : Comment
{
    public long ProjectId { get; set; }
    public virtual Project Project { get; set; } = null!;
}

public class TicketComment : Comment
{
    public long TicketId { get; set; }
    public virtual Ticket Ticket { get; set; } = null!;
}