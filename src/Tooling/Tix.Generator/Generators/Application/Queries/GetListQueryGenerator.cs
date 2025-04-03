using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Generators.Application.Queries;

public class GetListQueryGenerator(ITemplateGenerator template) : Generator
{
    private readonly ITemplateGenerator _template = template;

    public override void Generate(EntityInfo entity)
    {
        _template.Generate("application:queries:getlist", entity.Name, []);
    }
}