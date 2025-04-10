using Tix.Generator.Generators.Presentation.Console.Common.Interfaces.Handlers;
using Tix.Generator.Generators.Presentation.Console.Local.Handlers;
using Tix.Generator.Generators.Presentation.Console.Remote.Handlers;
using Tix.Generator.Generators.Presentation.Console.Tool.Commands;
using Tix.Generator.Models;

namespace Tix.Generator.Generators.Presentation.Console;

public class ConsoleGenerator(
    ArchiveHandlerInterfaceGenerator archiveHandlerInterface,
    DeleteHandlerInterfaceGenerator deleteHandlerInterface,
    ListHandlerInterfaceGenerator listHandlerInterface,
    NewHandlerInterfaceGenerator newHandlerInterface,
    RestoreHandlerInterfaceGenerator restoreHandlerInterface,
    ShowHandlerInterfaceGenerator showHandlerInterface,
    UpdateHandlerInterfaceGenerator updateHandlerInterface,
    LocalArchiveHandlerGenerator localArchiveHandler,
    LocalDeleteHandlerGenerator localDeleteHandler,
    LocalListHandlerGenerator localListHandler,
    LocalNewHandlerGenerator localNewHandler,
    LocalRestoreHandlerGenerator localRestoreHandler,
    LocalShowHandlerGenerator localShowHandler,
    LocalUpdateHandlerGenerator localUpdateHandler,
    RemoteArchiveHandlerGenerator remoteArchiveHandler,
    RemoteDeleteHandlerGenerator remoteDeleteHandler,
    RemoteListHandlerGenerator remoteListHandler,
    RemoteNewHandlerGenerator remoteNewHandler,
    RemoteRestoreHandlerGenerator remoteRestoreHandler,
    RemoteShowHandlerGenerator remoteShowHandler,
    RemoteUpdateHandlerGenerator remoteUpdateHandler,
    ArchiveCommandGenerator archiveCommand,
    DeleteCommandGenerator deleteCommand,
    ListCommandGenerator listCommand,
    NewCommandGenerator newCommand,
    RestoreCommandGenerator restoreCommand,
    ShowCommandGenerator showCommand,
    UpdateCommandGenerator updateCommand) : Generator
{
    private readonly ArchiveHandlerInterfaceGenerator _archiveHandlerInterface = archiveHandlerInterface;
    private readonly DeleteHandlerInterfaceGenerator _deleteHandlerInterface = deleteHandlerInterface;
    private readonly ListHandlerInterfaceGenerator _listHandlerInterface = listHandlerInterface;
    private readonly NewHandlerInterfaceGenerator _newHandlerInterface = newHandlerInterface;
    private readonly RestoreHandlerInterfaceGenerator _restoreHandlerInterface = restoreHandlerInterface;
    private readonly ShowHandlerInterfaceGenerator _showHandlerInterface = showHandlerInterface;
    private readonly UpdateHandlerInterfaceGenerator _updateHandlerInterface = updateHandlerInterface;
    private readonly LocalArchiveHandlerGenerator _localArchiveHandler = localArchiveHandler;
    private readonly LocalDeleteHandlerGenerator _localDeleteHandler = localDeleteHandler;
    private readonly LocalListHandlerGenerator _localListHandler = localListHandler;
    private readonly LocalNewHandlerGenerator _localNewHandler = localNewHandler;
    private readonly LocalRestoreHandlerGenerator _localRestoreHandler = localRestoreHandler;
    private readonly LocalShowHandlerGenerator _localShowHandler = localShowHandler;
    private readonly LocalUpdateHandlerGenerator _localUpdateHandler = localUpdateHandler;
    private readonly RemoteArchiveHandlerGenerator _remoteArchiveHandler = remoteArchiveHandler;
    private readonly RemoteDeleteHandlerGenerator _remoteDeleteHandler = remoteDeleteHandler;
    private readonly RemoteListHandlerGenerator _remoteListHandler = remoteListHandler;
    private readonly RemoteNewHandlerGenerator _remoteNewHandler = remoteNewHandler;
    private readonly RemoteRestoreHandlerGenerator _remoteRestoreHandler = remoteRestoreHandler;
    private readonly RemoteShowHandlerGenerator _remoteShowHandler = remoteShowHandler;
    private readonly RemoteUpdateHandlerGenerator _remoteUpdateHandler = remoteUpdateHandler;
    private readonly ArchiveCommandGenerator _archiveCommand = archiveCommand;
    private readonly DeleteCommandGenerator _deleteCommand = deleteCommand;
    private readonly ListCommandGenerator _listCommand = listCommand;
    private readonly NewCommandGenerator _newCommand = newCommand;
    private readonly RestoreCommandGenerator _restoreCommand = restoreCommand;
    private readonly ShowCommandGenerator _showCommand = showCommand;
    private readonly UpdateCommandGenerator _updateCommand = updateCommand;
    
    public override async Task GenerateAsync(EntityInfo entity, CancellationToken token = default)
    {
        await _newHandlerInterface.GenerateAsync(entity, token);
        await _showHandlerInterface.GenerateAsync(entity, token);
        await _listHandlerInterface.GenerateAsync(entity, token);
        await _updateHandlerInterface.GenerateAsync(entity, token);
        await _deleteHandlerInterface.GenerateAsync(entity, token);
        await _localNewHandler.GenerateAsync(entity, token);
        await _localShowHandler.GenerateAsync(entity, token);
        await _localListHandler.GenerateAsync(entity, token);
        await _localUpdateHandler.GenerateAsync(entity, token);
        await _localDeleteHandler.GenerateAsync(entity, token);
        await _remoteNewHandler.GenerateAsync(entity, token);
        await _remoteShowHandler.GenerateAsync(entity, token);
        await _remoteListHandler.GenerateAsync(entity, token);
        await _remoteUpdateHandler.GenerateAsync(entity, token);
        await _remoteDeleteHandler.GenerateAsync(entity, token);
        await _newCommand.GenerateAsync(entity, token);
        await _showCommand.GenerateAsync(entity, token);
        await _listCommand.GenerateAsync(entity, token);
        await _updateCommand.GenerateAsync(entity, token);
        await _deleteCommand.GenerateAsync(entity, token);

        if (entity.IsArchivable)
        {
            await _archiveHandlerInterface.GenerateAsync(entity, token);
            await _restoreHandlerInterface.GenerateAsync(entity, token);
            await _localArchiveHandler.GenerateAsync(entity, token);
            await _localRestoreHandler.GenerateAsync(entity, token);
            await _remoteArchiveHandler.GenerateAsync(entity, token);
            await _remoteRestoreHandler.GenerateAsync(entity, token);
            await _archiveCommand.GenerateAsync(entity, token);
            await _restoreCommand.GenerateAsync(entity, token);
        }
    }
}