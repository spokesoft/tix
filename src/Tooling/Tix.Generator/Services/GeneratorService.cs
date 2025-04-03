using Tix.Generator.Generators.Application;
using Tix.Generator.Generators.Domain;
using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

public class GeneratorService(
    ISourceCodeService source,
    DomainGenerator domain,
    ApplicationGenerator application)
{
    private readonly ISourceCodeService _source = source;
    private readonly DomainGenerator _domain = domain;
    private readonly ApplicationGenerator _application = application;

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
        _domain.Generate(entity);
        _application.Generate(entity);
    }
}