using Tix.Generator.Models;

namespace Tix.Generator.Generators.Application.DTOs;

public class DetailsDtoGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/DTOs/Details.tpl", "src/Core/Tix.Application/DTOs/{0}/{0}DetailsDto.cs" }
    };

    public override object ResolveModel(EntityInfo entity)
        => new
        {
            name = entity.Name,
            tid = entity.PrimaryKeyType,
            props = GetProperties(entity)
        };

    private static IEnumerable<string> GetProperties(EntityInfo entity) 
        => entity.ReadableProperties.Select(p => 
        {
            var nullable = p.IsNullable ? "?" : "";
            return $"public {p.Type}{nullable} {p.Name} {{ get; set; }}";
        });
}