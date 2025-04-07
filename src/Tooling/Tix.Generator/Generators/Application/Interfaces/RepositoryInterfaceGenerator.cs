namespace Tix.Generator.Generators.Application.Interfaces;

public class RepositoryInterfaceGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Interfaces/Repository.tpl", "src/Core/Application/Interfaces/Repositories/I{0}Repository.cs" }
    };
}