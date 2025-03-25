using Tix.Domain.Entities;

namespace Tix.Domain.Interfaces;

public interface IArchivable
{
    DateTime? ArchivedAt { get; set; }
    long? ArchivedById { get; set; }
    User? ArchivedBy { get; set; }
}