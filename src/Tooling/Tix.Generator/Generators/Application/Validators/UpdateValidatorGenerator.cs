namespace Tix.Generator.Generators.Application.Validators;

public class UpdateValidatorGenerator : FileGenerator
{
    public override Dictionary<string, string> TemplatePaths { get; set; } = new()
    {
        { "Application/Validators/Update.tpl", "src/Core/Application/Validators/{0}/Update{0}Validator.cs" }
    };
}