using Microsoft.Extensions.DependencyInjection;
using Tix.Console.Common.Interfaces.Handlers.Project;
using Tix.Console.Remote.Handlers.Project;

namespace Tix.Console.Remote.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRemoteHandlers(this IServiceCollection services)
    {
        services.AddSingleton<ICreateProjectHandler, RemoteCreateProjectHandler>();
        return services;
    }
}