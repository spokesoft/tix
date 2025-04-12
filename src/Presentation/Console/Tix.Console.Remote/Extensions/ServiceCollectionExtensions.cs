using Microsoft.Extensions.DependencyInjection;

namespace Tix.Console.Remote.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRemoteHandlers(this IServiceCollection services)
    {
        return services;
    }
}