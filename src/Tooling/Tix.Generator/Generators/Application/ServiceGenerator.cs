namespace Tix.Generator.Generators.Application;

public class ServiceGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Service.tpl", "src/Core/Application/Services/{0}Service.cs" }
    };
}