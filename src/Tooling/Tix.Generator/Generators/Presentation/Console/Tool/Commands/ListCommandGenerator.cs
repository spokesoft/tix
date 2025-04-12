using Tix.Generator.Models;
using Pluralize.NET;

namespace Tix.Generator.Generators.Presentation.Console.Tool.Commands;

public class ListCommandGenerator : FileGenerator
{
    private readonly Pluralizer _pluralizer = new();

    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Tool/Commands/List.tpl", "src/Presentation/Console/Tix.Console.Tool/Commands/List/List{0}Command.cs" }
    };

    public override string ResolveOutputPath(string outputFormat, EntityInfo entity)
        => string.Format(outputFormat, _pluralizer.Pluralize(entity.Name));
    
    public override object ResolveModel(EntityInfo entity)
        => new
        {
            name = entity.Name,
            var = LowercaseFirstLetter(entity.Name),
            tid = entity.PrimaryKeyType,
            plural = _pluralizer.Pluralize(entity.Name),
            pluralvar = LowercaseFirstLetter(_pluralizer.Pluralize(entity.Name)),
            propnames = GetPropertyNames(entity)
        };

    private static IEnumerable<string> GetPropertyNames(EntityInfo entity)
        => entity.WritableProperties.Select(p => p.Name);
    
    protected static string LowercaseFirstLetter(string input) => string.IsNullOrEmpty(input) ? input : char.ToLower(input[0]) + input[1..];
}