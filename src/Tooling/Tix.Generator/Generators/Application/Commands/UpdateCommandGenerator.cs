using Tix.Generator.Models;

namespace Tix.Generator.Generators.Application.Commands;

public class UpdateCommandGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Commands/Update.tpl", "src/Core/Tix.Application/Commands/{0}/Update{0}Command.cs" },
        { "Application/Commands/UpdateHandler.tpl", "src/Core/Tix.Application/Commands/{0}/Update{0}Handler.cs" }
    };

    public override object ResolveModel(EntityInfo entity)
    {
        return new { 
            name = entity.Name, 
            tid = entity.PrimaryKeyType,
            props = GetProperties(entity) };
    }

    private IEnumerable<string> GetProperties(EntityInfo entity)
    {
        var builder = new List<string>();
        foreach (var prop in entity.WritableProperties)
        {
            var nullable = prop.IsNullable ? "?" : "";
            builder.Add($"public {prop.Type}{nullable} {prop.Name} {{ get; set; }}");
        }
        return builder;
    }
}