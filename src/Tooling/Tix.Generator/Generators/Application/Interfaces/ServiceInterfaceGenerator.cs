namespace Tix.Generator.Generators.Application.Interfaces;

public class ServiceInterfaceGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Interfaces/Service.tpl", "src/Core/Application/Interfaces/Services/I{0}Service.cs" }
    };
}