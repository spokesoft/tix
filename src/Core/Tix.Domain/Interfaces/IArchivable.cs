using Tix.Domain.Entities;

namespace Tix.Domain.Interfaces;

public interface IArchivable
{
    DateTime? ArchivedAt { get; }
    long? ArchivedById { get; }
    User? ArchivedBy { get; }
}