using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

public class GeneratorService(
    ISourceCodeService source, 
    ITemplateGeneratorService template, 
    IOutputPathService outputPath)
{
    private readonly ISourceCodeService _source = source;

    private readonly DomainGeneratorService _domain = new(template, outputPath);
    private readonly ApplicationGeneratorService _application = new(template, outputPath);
    private readonly InfrastructureGeneratorService _infrastructure = new(template, outputPath);
    private readonly ApiGeneratorService _api = new(template, outputPath);
    private readonly MvcGeneratorService _mvc = new(template, outputPath);
    private readonly ConsoleGeneratorService _console = new(template, outputPath);

    public void GenerateAll()
    {
        var entities = _source.GetAllEntities();
        foreach (var entity in entities)
        {
            GenerateAll(entity);
        }
    }

    public void GenerateAll(EntityInfo entity)
    {
        _domain.GenerateAll(entity);
        // _application.GenerateAll(entity);
        // _infrastructure.GenerateAll(entity);
        // _api.GenerateAll(entity);
        // _mvc.GenerateAll(entity);
        // _console.GenerateAll(entity);
    }
}