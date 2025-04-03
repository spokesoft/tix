using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Generators.Application.Commands;

public class RestoreCommandGenerator(ITemplateGenerator template) : Generator
{
    private readonly ITemplateGenerator _template = template;

    public override void Generate(EntityInfo entity)
    {
        _template.Generate("application:commands:restore", entity.Name, []);
    }
}