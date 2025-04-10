using Microsoft.Extensions.DependencyInjection;
using Tix.Console.Common.Interfaces.Handlers.Project;
using Tix.Console.Local.Handlers.Project;

namespace Tix.Console.Local.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLocalHandlers(this IServiceCollection services)
    {
        services.AddSingleton<ICreateProjectHandler, LocalCreateProjectHandler>();
        return services;
    }
}