using Tix.Generator.Generators.Application.Commands;
using Tix.Generator.Generators.Application.DTOs;
using Tix.Generator.Generators.Application.Interfaces;
using Tix.Generator.Generators.Application.Queries;
using Tix.Generator.Generators.Application.Validators;
using Tix.Generator.Models;

namespace Tix.Generator.Generators.Application;

public class ApplicationGenerator(
    ArchiveCommandGenerator archiveCommand,
    ArchiveRangeCommandGenerator archiveRangeCommand,
    CreateCommandGenerator createCommand,
    CreateRangeCommandGenerator createRangeCommand,
    DeleteCommandGenerator deleteCommand,
    DeleteRangeCommandGenerator deleteRangeCommand,
    RestoreCommandGenerator restoreCommand,
    RestoreRangeCommandGenerator restoreRangeCommand,
    UpdateCommandGenerator updateCommand,
    UpdateRangeCommandGenerator updateRangeCommand,
    DetailsDtoGenerator detailsDto,
    ListItemDtoGenerator listItemDto,
    RepositoryInterfaceGenerator repositoryInterface,
    ServiceInterfaceGenerator serviceInterface,
    GetByIdQueryGenerator getByIdQuery,
    GetListQueryGenerator getListQuery,
    ServiceGenerator service,
    CreateValidatorGenerator createValidator,
    UpdateValidatorGenerator updateValidator,
    DeleteValidatorGenerator deleteValidator) : Generator
{
    private readonly ArchiveCommandGenerator _archiveCommand = archiveCommand;
    private readonly ArchiveRangeCommandGenerator _archiveRangeCommand = archiveRangeCommand;
    private readonly CreateCommandGenerator _createCommand = createCommand;
    private readonly CreateRangeCommandGenerator _createRangeCommand = createRangeCommand;
    private readonly DeleteCommandGenerator _deleteCommand = deleteCommand;
    private readonly DeleteRangeCommandGenerator _deleteRangeCommand = deleteRangeCommand;
    private readonly RestoreCommandGenerator _restoreCommand = restoreCommand;
    private readonly RestoreRangeCommandGenerator _restoreRangeCommand = restoreRangeCommand;
    private readonly UpdateCommandGenerator _updateCommand = updateCommand;
    private readonly UpdateRangeCommandGenerator _updateRangeCommand = updateRangeCommand;
    private readonly DetailsDtoGenerator _detailsDto = detailsDto;
    private readonly ListItemDtoGenerator _listItemDto = listItemDto;
    private readonly RepositoryInterfaceGenerator _repositoryInterface = repositoryInterface;
    private readonly ServiceInterfaceGenerator _serviceInterface = serviceInterface;
    private readonly GetByIdQueryGenerator _getByIdQuery = getByIdQuery;
    private readonly GetListQueryGenerator _getListQuery = getListQuery;
    private readonly ServiceGenerator _service = service;
    private readonly CreateValidatorGenerator _createValidator = createValidator;
    private readonly UpdateValidatorGenerator _updateValidator = updateValidator;
    private readonly DeleteValidatorGenerator _deleteValidator = deleteValidator;
    
    public override async Task GenerateAsync(EntityInfo entity, CancellationToken token = default)
    {
        // Generate commands
        await _createCommand.GenerateAsync(entity, token);
        await _createRangeCommand.GenerateAsync(entity, token);
        await _deleteCommand.GenerateAsync(entity, token);
        await _deleteRangeCommand.GenerateAsync(entity, token);
        await _updateCommand.GenerateAsync(entity, token);
        await _updateRangeCommand.GenerateAsync(entity, token);

        if (entity.IsArchivable)
        {
            await _archiveCommand.GenerateAsync(entity, token);
            await _archiveRangeCommand.GenerateAsync(entity, token);
            await _restoreCommand.GenerateAsync(entity, token);
            await _restoreRangeCommand.GenerateAsync(entity, token);
        }

        // Generate DTOs
        await _detailsDto.GenerateAsync(entity, token);
        await _listItemDto.GenerateAsync(entity, token);

        // Generate interfaces
        await _repositoryInterface.GenerateAsync(entity, token);
        await _serviceInterface.GenerateAsync(entity, token);

        // Generate queries
        await _getByIdQuery.GenerateAsync(entity, token);
        await _getListQuery.GenerateAsync(entity, token);

        // Generate service
        await _service.GenerateAsync(entity, token);

        // Generate validators
        await _createValidator.GenerateAsync(entity, token);
        await _updateValidator.GenerateAsync(entity, token);
        await _deleteValidator.GenerateAsync(entity, token);
    }
}