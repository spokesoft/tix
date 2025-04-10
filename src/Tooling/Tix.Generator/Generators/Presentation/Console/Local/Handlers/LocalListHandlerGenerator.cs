using Pluralize.NET;
using Tix.Generator.Models;

namespace Tix.Generator.Generators.Presentation.Console.Local.Handlers;

public class LocalListHandlerGenerator : FileGenerator
{
    private readonly Pluralizer _pluralizer = new();
    
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Local/Handlers/List.tpl", "src/Presentation/Console/Tix.Console.Local/Handlers/List/LocalList{0}Handler.cs" }
    };

    public override object ResolveModel(EntityInfo entity)
        => new { name = entity.Name, 
                 tid = entity.PrimaryKeyType, 
                 plural = _pluralizer.Pluralize(entity.Name) };

    public override string ResolveOutputPath(string outputFormat, EntityInfo entity)
        => string.Format(outputFormat, _pluralizer.Pluralize(entity.Name));
}