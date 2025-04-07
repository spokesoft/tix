using Tix.Generator.Generators.Domain.Events;
using Tix.Generator.Generators.Domain.Exceptions;
using Tix.Generator.Models;

namespace Tix.Generator.Generators.Domain;

public class DomainGenerator(
    ArchivedEventGenerator archivedEvent,
    CreatedEventGenerator createdEvent,
    DeletedEventGenerator deletedEvent,
    RestoredEventGenerator restoredEvent,
    UpdatedEventGenerator updatedEvent,
    DuplicateExceptionGenerator duplicateException,
    NotFoundExceptionGenerator notFoundException) : Generator
{
    private readonly ArchivedEventGenerator _archivedEvent = archivedEvent;
    private readonly CreatedEventGenerator _createdEvent = createdEvent;
    private readonly DeletedEventGenerator _deletedEvent = deletedEvent;
    private readonly RestoredEventGenerator _restoredEvent = restoredEvent;
    private readonly UpdatedEventGenerator _updatedEvent = updatedEvent;
    private readonly DuplicateExceptionGenerator _duplicateException = duplicateException;
    private readonly NotFoundExceptionGenerator _notFoundException = notFoundException;
    
    public override async Task GenerateAsync(EntityInfo entity, CancellationToken token = default)
    {
        await _createdEvent.GenerateAsync(entity, token);
        await _updatedEvent.GenerateAsync(entity, token);
        await _deletedEvent.GenerateAsync(entity, token);
        
        if (entity.IsArchivable)
        {
            await _archivedEvent.GenerateAsync(entity, token);
            await _restoredEvent.GenerateAsync(entity, token);
        }
        
        await _notFoundException.GenerateAsync(entity, token);
    }
}