using Tix.Generator.Generators.Application.Commands;
using Tix.Generator.Generators.Application.DTOs;
using Tix.Generator.Generators.Application.Interfaces;
using Tix.Generator.Generators.Application.Queries;
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
    SelectListItemDtoGenerator selectListItemDto,
    RepositoryInterfaceGenerator repositoryInterface,
    ServiceInterfaceGenerator serviceInterface,
    GetByIdQueryGenerator getByIdQuery,
    GetListQueryGenerator getListQuery,
    SearchQueryGenerator searchQuery,
    ServiceGenerator service) : Generator
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
    private readonly SelectListItemDtoGenerator _selectListItemDto = selectListItemDto;
    private readonly RepositoryInterfaceGenerator _repositoryInterface = repositoryInterface;
    private readonly ServiceInterfaceGenerator _serviceInterface = serviceInterface;
    private readonly GetByIdQueryGenerator _getByIdQuery = getByIdQuery;
    private readonly GetListQueryGenerator _getListQuery = getListQuery;
    private readonly SearchQueryGenerator _searchQuery = searchQuery;
    private readonly ServiceGenerator _service = service;
    
    public override void Generate(EntityInfo entity)
    {
        // Generate commands
        _createCommand.Generate(entity);
        _createRangeCommand.Generate(entity);
        _deleteCommand.Generate(entity);
        _deleteRangeCommand.Generate(entity);
        _updateCommand.Generate(entity);
        _updateRangeCommand.Generate(entity);

        if (entity.IsArchivable)
        {
            _archiveCommand.Generate(entity);
            _archiveRangeCommand.Generate(entity);
            _restoreCommand.Generate(entity);
            _restoreRangeCommand.Generate(entity);
        }

        // Generate DTOs
        _detailsDto.Generate(entity);
        _listItemDto.Generate(entity);
        _selectListItemDto.Generate(entity);

        // Generate interfaces
        _repositoryInterface.Generate(entity);
        _serviceInterface.Generate(entity);

        // Generate queries
        _getByIdQuery.Generate(entity);
        _getListQuery.Generate(entity);
        _searchQuery.Generate(entity);

        // Generate service
        _service.Generate(entity);
    }
}