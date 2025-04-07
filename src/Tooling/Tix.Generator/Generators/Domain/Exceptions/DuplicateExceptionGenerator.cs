namespace Tix.Generator.Generators.Domain.Exceptions;

public class DuplicateExceptionGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Domain/Exceptions/Duplicate.tpl", "src/Core/Domain/Exceptions/{0}/Duplicate{0}Exception.cs" }
    };
}