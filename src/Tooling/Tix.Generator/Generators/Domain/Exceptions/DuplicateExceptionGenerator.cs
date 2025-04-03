using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Generators.Domain.Exceptions;

public class DuplicateExceptionGenerator(ITemplateGenerator template) : Generator
{
    private readonly ITemplateGenerator _template = template;
    
    public override void Generate(EntityInfo entity)
    {
        _template.Generate("domain:exceptions:duplicate", entity.Name, []);
    }
}