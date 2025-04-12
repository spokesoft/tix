using Tix.Generator.Models;

namespace Tix.Generator.Generators.Presentation.Console.Tool.Commands;

public class NewCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Presentation/Console/Tool/Commands/New.tpl", "src/Presentation/Console/Tix.Console.Tool/Commands/New/New{0}Command.cs" }
    };

    public override object ResolveModel(EntityInfo entity)
    {
        return new
        {
            name = entity.Name,
            tid = entity.PrimaryKeyType,
            props = GetProperties(entity),
            propnames = GetPropertyNames(entity)
        };
    }

    private IEnumerable<string> GetProperties(EntityInfo entity)
    {
        var builder = new List<string>();
        foreach (var property in entity.WritableProperties)
        {
            var nullable = property.IsNullable ? "?" : "";
            builder.Add($"public {property.Type}{nullable} {property.Name} {{ get; set; }}");
        }
        return builder;
    }

    private static IEnumerable<string> GetPropertyNames(EntityInfo entity)
        => entity.WritableProperties.Select(p => p.Name);
}