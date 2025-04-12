namespace Tix.Generator.Generators.Application.DTOs;

public class ListItemDtoGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/DTOs/ListItem.tpl", "src/Core/Tix.Application/DTOs/{0}/{0}ListItemDto.cs" }
    };
}