using Tix.Generator.Models;
using Pluralize.NET;

namespace Tix.Generator.Generators.Presentation.Console.Common.Interfaces.Handlers;

public class ListHandlerInterfaceGenerator : FileGenerator
{
    private readonly Pluralizer _pluralizer = new();

    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Common/Interfaces/Handlers/List.tpl", "src/Presentation/Console/Tix.Console.Common/Interfaces/Handlers/List/IList{0}Handler.cs" }
    };

    public override object ResolveModel(EntityInfo entity)
        => new { name = entity.Name, 
                 tid = entity.PrimaryKeyType, 
                 plural = _pluralizer.Pluralize(entity.Name) };

    public override string ResolveOutputPath(string outputFormat, EntityInfo entity)
        => string.Format(outputFormat, _pluralizer.Pluralize(entity.Name));
}