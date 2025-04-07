namespace Tix.Generator.Generators.Application.DTOs;

public class DetailsDtoGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/DTOs/Details.tpl", "src/Core/Application/DTOs/{0}/{0}DetailsDto.cs" }
    };
}