namespace Tix.Domain.Exceptions.Ticket;

public class TicketNotFoundException(long id) : NotFoundException(nameof(Ticket), $"{id}")
{
    public long Id { get; init; } = id;
}