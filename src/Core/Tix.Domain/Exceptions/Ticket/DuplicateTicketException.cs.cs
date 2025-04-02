namespace Tix.Domain.Exceptions.Ticket;

public class DuplicateTicketException(long id) : DuplicateException(nameof(Ticket), $"{id}")
{
    public long Id { get; init; } = id;
}