using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

public class DomainGeneratorService(ITemplateGeneratorService template, IOutputPathService outputPath)
{
    private readonly ITemplateGeneratorService _template = template;
    private readonly IOutputPathService _outputPath = outputPath;

    public void GenerateAll(EntityInfo entity)
    {
        //GenerateDomainEvents(entity);
        GenerateDomainExceptions(entity);
    }

    public void GenerateDomainEntity(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.DomainEntity, entity);
    }

    // Domain events
    public void GenerateDomainEvents(EntityInfo entity)
    {
        GenerateDomainEventsCreated(entity);
        GenerateDomainEventsUpdated(entity);
        GenerateDomainEventsDeleted(entity);
    }

    public void GenerateDomainEventsCreated(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.DomainEventsCreated, entity);
    }

    public void GenerateDomainEventsUpdated(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.DomainEventsUpdated, entity);
    }

    public void GenerateDomainEventsDeleted(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.DomainEventsDeleted, entity);
    }

    // Domain exceptions
    public void GenerateDomainExceptions(EntityInfo entity)
    {
        GenerateDomainExceptionsNotFound(entity);
        GenerateDomainExceptionsDuplicate(entity);
    }

    public void GenerateDomainExceptionsNotFound(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.DomainExceptionsNotFound, entity);
    }

    public void GenerateDomainExceptionsDuplicate(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.DomainExceptionsDuplicate, entity);
    }
}