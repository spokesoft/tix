namespace Tix.Generator.Generators.Infrastructure;

public class ConfigurationGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Infrastructure/Configuration.tpl", "src/Infrastructure/Tix.Infrastructure.Common/Configurations/{0}Configuration.cs" }
    };
}