using Microsoft.Extensions.DependencyInjection;

namespace Tix.Console.Local.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLocalHandlers(this IServiceCollection services)
    {
        return services;
    }
}