namespace Tix.Generator.Generators.Application.Queries;

public class GetListQueryGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Queries/GetList.tpl", "src/Core/Tix.Application/Queries/{0}/Get{0}ListQuery.cs" },
        { "Application/Queries/GetListHandler.tpl", "src/Core/Tix.Application/Queries/{0}/Get{0}ListHandler.cs" }
    };
}