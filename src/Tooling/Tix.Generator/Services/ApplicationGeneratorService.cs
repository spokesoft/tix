using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

public class ApplicationGeneratorService(ITemplateGeneratorService template, IOutputPathService outputPath)
{
    private readonly ITemplateGeneratorService _template = template;
    private readonly IOutputPathService _outputPath = outputPath;

    public void GenerateAll(EntityInfo entity)
    {
        GenerateApplicationCommands(entity);
        GenerateApplicationDTOs(entity);
        GenerateApplicationInterfaces(entity);
        GenerateApplicationQueries(entity);
        GenerateApplicationService(entity);
        GenerateApplicationValidators(entity);
    }

    #region Application Command Templates

    public void GenerateApplicationCommands(EntityInfo entity)
    {
        GenerateApplicationCommandsCreate(entity);
        GenerateApplicationCommandsUpdate(entity);
        GenerateApplicationCommandsDelete(entity);
        GenerateApplicationCommandsArchive(entity);
        GenerateApplicationCommandsRestore(entity);
        GenerateApplicationCommandsCreateRange(entity);
        GenerateApplicationCommandsUpdateRange(entity);
        GenerateApplicationCommandsDeleteRange(entity);
        GenerateApplicationCommandsArchiveRange(entity);
        GenerateApplicationCommandsRestoreRange(entity);
    }

    public void GenerateApplicationCommandsCreate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationCommandsCreate, entity);
    }

    public void GenerateApplicationCommandsUpdate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationCommandsUpdate, entity);
    }

    public void GenerateApplicationCommandsDelete(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationCommandsDelete, entity);
    }

    public void GenerateApplicationCommandsArchive(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationCommandsArchive, entity);
    }

    public void GenerateApplicationCommandsRestore(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationCommandsRestore, entity);
    }

    public void GenerateApplicationCommandsCreateRange(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationCommandsCreateRange, entity);
    }

    public void GenerateApplicationCommandsUpdateRange(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationCommandsUpdateRange, entity);
    }

    public void GenerateApplicationCommandsDeleteRange(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationCommandsDeleteRange, entity);
    }

    public void GenerateApplicationCommandsArchiveRange(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationCommandsArchiveRange, entity);
    }

    public void GenerateApplicationCommandsRestoreRange(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationCommandsRestoreRange, entity);
    }

    #endregion
    #region Application DTO Templates

    public void GenerateApplicationDTOs(EntityInfo entity)
    {
        GenerateApplicationDTOsDetails(entity);
        GenerateApplicationDTOsListItem(entity);
        GenerateApplicationDTOsSelectListItem(entity);
    }

    public void GenerateApplicationDTOsDetails(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationDTOsDetails, entity);
    }

    public void GenerateApplicationDTOsListItem(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationDTOsListItem, entity);
    }

    public void GenerateApplicationDTOsSelectListItem(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationDTOsSelectListItem, entity);
    }

    #endregion
    #region Application Interface Templates

    public void GenerateApplicationInterfaces(EntityInfo entity)
    {
        GenerateApplicationInterfacesRepository(entity);
        GenerateApplicationInterfacesService(entity);
    }

    public void GenerateApplicationInterfacesRepository(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationInterfacesRepository, entity);
    }

    public void GenerateApplicationInterfacesService(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationInterfacesService, entity);
    }

    #endregion
    #region Application Query Templates

    public void GenerateApplicationQueries(EntityInfo entity)
    {
        GenerateApplicationQueriesGetList(entity);
        GenerateApplicationQueriesGetById(entity);
        GenerateApplicationQueriesGetByCode(entity);
        GenerateApplicationQueriesGetByName(entity);
    }

    public void GenerateApplicationQueriesGetList(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationQueriesGetList, entity);
    }

    public void GenerateApplicationQueriesGetById(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationQueriesGetById, entity);
    }

    public void GenerateApplicationQueriesGetByCode(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationQueriesGetByCode, entity);
    }

    public void GenerateApplicationQueriesGetByName(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationQueriesGetByName, entity);
    }

    #endregion
    #region Application Service Template

    public void GenerateApplicationService(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationService, entity);
    }

    #endregion
    #region Application Validator Templates

    public void GenerateApplicationValidators(EntityInfo entity)
    {
        GenerateApplicationValidatorsCreate(entity);
        GenerateApplicationValidatorsUpdate(entity);
        GenerateApplicationValidatorsDelete(entity);
    }

    public void GenerateApplicationValidatorsCreate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationValidatorsCreate, entity);
    }

    public void GenerateApplicationValidatorsUpdate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationValidatorsUpdate, entity);
    }

    public void GenerateApplicationValidatorsDelete(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ApplicationValidatorsDelete, entity);
    }

    #endregion
}