using DatabaseProxyDemo.Abstractions;
using DatabaseProxyDemo.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DatabaseProxyDemo.Extensions;
internal static class ServiceCollectionExtensions {
    public static IServiceCollection AddProxyServices(this IServiceCollection services) {
        services.AddScoped<IDatabase , FakeDatabase>();
        return services;
    }
}
