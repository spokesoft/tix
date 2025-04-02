using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

public class InfrastructureGeneratorService(ITemplateGeneratorService template, IOutputPathService outputPath)
{
    private readonly ITemplateGeneratorService _template = template;
    private readonly IOutputPathService _outputPath = outputPath;

    public void GenerateAll(EntityInfo entity)
    {
        GenerateInfrastructureConfiguration(entity);
        GenerateInfrastructureRepository(entity);
    }

    // Infrastructure Template Methods
    public void GenerateInfrastructureIdentityEntity(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.InfrastructureIdentityEntity, entity);
    }

    public void GenerateInfrastructureConfiguration(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.InfrastructureConfiguration, entity);
    }

    public void GenerateInfrastructureRepository(EntityInfo entity)
    {
        var templateArgs = new Dictionary<string, string>
        {
            { "entity", entity.Name }
        };
        _template.Generate(TemplateIdentity.InfrastructureRepository, entity);
    }
}