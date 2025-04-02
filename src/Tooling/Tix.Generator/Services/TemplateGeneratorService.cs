using System;
using System.Diagnostics;
using System.IO;
using Tix.Generator.Interfaces;
using Tix.Generator.Models;

namespace Tix.Generator.Services;

public class TemplateGeneratorService(IOutputPathService outputPath, bool force = false) : ITemplateGeneratorService
{
    private readonly IOutputPathService _outputPath = outputPath;
    private readonly bool _force = force;

    public void Generate(string templateId, EntityInfo? entity = null)
    {
        if (entity == null)
            return;

        var path = _outputPath.Generate(templateId, entity);
        var exists = File.Exists(path);
        
        if (!exists || _force)
        {
            var directory = Path.GetDirectoryName(path);
            var fileName = Path.GetFileNameWithoutExtension(path);

            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            // Create and configure the process
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = $"new {templateId} -n {fileName} -o \"{directory}\" --force --entity {entity.Name}",
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
                    Console.WriteLine($"Successfully generated {templateId} for {entity.Name}");
                }
                else
                {
                    var error = process.StandardError.ReadToEnd();
                    Console.WriteLine($"Error generating template:\n\n{error}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to execute dotnet new command: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"Skipped {templateId} for {entity.Name}");
        }
    }
}