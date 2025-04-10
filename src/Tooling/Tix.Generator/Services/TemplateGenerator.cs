using System.Diagnostics;
using Tix.Generator.Interfaces;

namespace Tix.Generator.Services;

public class TemplateGenerator(
    ITemplatePathResolver pathResolver) : ITemplateGenerator
{
    private readonly bool _force = false;
    private readonly ITemplatePathResolver _pathResolver = pathResolver;

    public void Generate(string templateId, string entityName, string[] args)
    {
        var path = _pathResolver.GetPath(templateId, entityName);
        var exists = File.Exists(path);
        
        if (!exists || _force)
        {
            var directory = Path.GetDirectoryName(path);
            var fileName = Path.GetFileNameWithoutExtension(path);

            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            
            var forceArg = _force ? " --force" : "";
            var templateArgs = args.Length > 0 ? " " + string.Join(" ", args) : "";

            // Create and configure the process
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = $"new {templateId} -n {fileName} -o \"{directory}\" --entity {entityName}{templateArgs}{forceArg}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            try
            {
                process.Start();
                process.WaitForExit();
                
                if (process.ExitCode == 0)
                {
                    System.Console.WriteLine($"Successfully generated {templateId} for {entityName}");
                }
                else
                {
                    var error = process.StandardError.ReadToEnd();
                    System.Console.WriteLine($"Error generating template:\n\n{error}");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Failed to execute dotnet new command: {ex.Message}");
            }
        }
        else
        {
            System.Console.WriteLine($"Skipped {templateId} for {entityName}. Already exists.");
        }
    }
}