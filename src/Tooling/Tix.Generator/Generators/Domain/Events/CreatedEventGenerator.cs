using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Generators.Domain.Events;

public class CreatedEventGenerator(ITemplateGenerator template) : Generator
{
    private readonly ITemplateGenerator _template = template;

    public override void Generate(EntityInfo entity)
    {
        _template.Generate("domain:events:created", entity.Name, []);
    }
}