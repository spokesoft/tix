namespace Tix.Generator.Generators.Infrastructure;

public class RepositoryGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Infrastructure/Repository.tpl", "src/Infrastructure/Tix.Infrastructure.Common/Repositories/{0}Repository.cs" }
    };
}