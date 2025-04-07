namespace Tix.Generator.Generators.Application.Validators;

public class DeleteValidatorGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Validators/Delete.tpl", "src/Core/Application/Validators/{0}/Delete{0}Validator.cs" }
    };
}