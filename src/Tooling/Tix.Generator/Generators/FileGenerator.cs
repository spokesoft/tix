using System.Text.Json;
using Scriban;
using Scriban.Runtime;
using Tix.Generator.Models;

namespace Tix.Generator.Generators;

public abstract class FileGenerator : Generator
{
    public abstract Dictionary<string, string> TemplatePaths { get; set; }

    public override async Task GenerateAsync(EntityInfo entity, CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();

        object model = ResolveModel(entity);
        foreach (var path in TemplatePaths)
        {
            string templatePath = path.Key;
            string outputFormat = path.Value;
            string outputPath = ResolveOutputPath(outputFormat, entity);
            await RenderAsync(templatePath, outputPath, model);
        }
    }

    public virtual string ResolveOutputPath(string outputFormat, EntityInfo entity)
        => string.Format(outputFormat, entity.Name);

    public virtual object ResolveModel(EntityInfo entity)
    {
        return new { name = entity.Name, tid = entity.PrimaryKeyType };
    }

    private static async Task RenderAsync(string templatePath, string outputPath, object model)
    {
        try
        {
            var directory = Path.GetDirectoryName(outputPath);
            if (directory != null && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            templatePath = Path.Join("Templates", templatePath);
            string templateContent = await File.ReadAllTextAsync(templatePath);
            var template = Template.Parse(templateContent);

            var data = new ScriptObject();
            data.Import(model);

            var context = new TemplateContext();
            context.PushGlobal(data);

            string result = await template.RenderAsync(context);
            await File.WriteAllTextAsync(outputPath, result);
            
            Console.WriteLine($"Generated: {outputPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generating {outputPath}: {ex.Message}");
            throw;
        }
    }
}