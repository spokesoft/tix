namespace Tix.Generator.Generators.Application.Queries;

public class GetByIdQueryGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Queries/GetById.tpl", "src/Core/Application/Queries/{0}/Get{0}ByIdQuery.cs" },
        { "Application/Queries/GetByIdHandler.tpl", "src/Core/Application/Queries/{0}/Get{0}ByIdHandler.cs" }
    };
}