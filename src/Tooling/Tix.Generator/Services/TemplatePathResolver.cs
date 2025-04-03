using Microsoft.Extensions.Configuration;
using Tix.Generator.Interfaces;

namespace Tix.Generator.Services;

public class TemplatePathResolver(IConfiguration configuration) : ITemplatePathResolver
{
    private readonly IConfiguration _configuration = configuration;

    public string GetPath(string shortName, string entityName)
    {
        var format = FindPathTemplate(shortName);

        if (string.IsNullOrEmpty(format))
        {
            throw new ArgumentException($"Could not resolve path for [{shortName}]");
        }

        return string.Format(format, entityName);
    }

    private string? FindPathTemplate(string shortName)
    {
        foreach (var section in _configuration.GetSection("Templates").GetChildren())
        {
            var result = SearchForTemplate(section, shortName);
            if (!string.IsNullOrEmpty(result)) return result;
        }
        return null;
    }

    private static string? SearchForTemplate(IConfigurationSection section, string shortName)
    {
        if (section.GetChildren().Any(c => c.Key == "shortName" && c.Value == shortName))
        {
            return section.GetChildren().FirstOrDefault(c => c.Key == "path")?.Value;
        }

        foreach (var child in section.GetChildren())
        {
            if (child.Key == "shortName" || child.Key == "path") continue;
            var result = SearchForTemplate(child, shortName);
            if (!string.IsNullOrEmpty(result))
            {
                return result;
            }
        }

        return null;
    }
}