using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Tix.Generator.Interfaces;

namespace Tix.Generator.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddGenerators(this IServiceCollection services, Assembly? assembly = null)
    {
        assembly ??= Assembly.GetCallingAssembly();
        var generatorTypes = assembly.GetTypes()
                .Where(t => typeof(IGenerator).IsAssignableFrom(t) &&
                            !t.IsInterface &&
                            !t.IsAbstract).ToList();
        foreach (var type in generatorTypes)
        {
            // Register as both the concrete type and as IGenerator
            services.AddTransient(type);
            services.AddTransient(typeof(IGenerator), type);
        }
        return services;
    }
}