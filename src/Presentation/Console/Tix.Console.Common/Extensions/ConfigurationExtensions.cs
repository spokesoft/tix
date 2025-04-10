using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Tix.Console.Common.Configuration;
using Tix.Console.Common.Enums;

namespace Tix.Console.Common.Extensions;

public static class ConfigurationExtensions
{
    public static IServiceCollection AddTixOptions(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<TixOptions>(
            configuration.GetSection(TixOptions.SectionName));

        services.AddSingleton<IValidateOptions<TixOptions>, TixOptionsValidator>();
        
        return services;
    }

    public static ExecutionMode GetExecutionMode(this IConfiguration configuration)
    {
        var modeName = configuration[$"{TixOptions.SectionName}:Mode"];

        return !string.IsNullOrEmpty(modeName) &&
               Enum.TryParse<ExecutionMode>(modeName, true, out var mode)
            ? mode
            : ExecutionMode.Local;
    }
}