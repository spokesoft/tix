namespace Tix.Generator.Generators.Domain.Events;

public class DeletedEventGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Domain/Events/Deleted.tpl", "src/Core/Domain/Events/{0}/{0}Deleted.cs" },
        { "Domain/Events/DeletedHandler.tpl", "src/Core/Domain/Events/{0}/{0}DeletedHandler.cs" }
    };
}