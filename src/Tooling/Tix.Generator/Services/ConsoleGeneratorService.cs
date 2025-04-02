using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

public class ConsoleGeneratorService(ITemplateGeneratorService template, IOutputPathService outputPath)
{
    private readonly ITemplateGeneratorService _template = template;
    private readonly IOutputPathService _outputPath = outputPath;

    public void GenerateAll(EntityInfo entity)
    {
        GenerateConsoleCommands(entity);
        GenerateConsoleViews(entity);
    }

    public void GenerateConsoleCommands(EntityInfo entity)
    {
        GenerateConsoleCommandsCreate(entity);
        GenerateConsoleCommandsUpdate(entity);
        GenerateConsoleCommandsDelete(entity);
    }

    public void GenerateConsoleCommandsCreate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ConsoleCommandsCreate, entity);
    }

    public void GenerateConsoleCommandsUpdate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ConsoleCommandsUpdate, entity);
    }

    public void GenerateConsoleCommandsDelete(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ConsoleCommandsDelete, entity);
    }

    public void GenerateConsoleViews(EntityInfo entity)
    {
        GenerateConsoleViewsDetails(entity);
        GenerateConsoleViewsList(entity);
        GenerateConsoleViewsPagedList(entity);
    }

    public void GenerateConsoleViewsDetails(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ConsoleViewsDetails, entity);
    }

    public void GenerateConsoleViewsList(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ConsoleViewsList, entity);
    }

    public void GenerateConsoleViewsPagedList(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.ConsoleViewsPagedList, entity);
    }
}