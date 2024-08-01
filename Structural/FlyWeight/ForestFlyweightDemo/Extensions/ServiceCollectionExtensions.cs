using ForestFlyweightDemo.Abstractions;
using ForestFlyweightDemo.Factory;
using ForestFlyweightDemo.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ForestFlyweightDemo.Extensions;
internal static class ServiceCollectionExtensions {
    public static IServiceCollection AddTrees(this IServiceCollection services) {
        services.AddTransient<ITree , OrangeTree>();
        services.AddTransient<ITree , LemonTree>();
        services.AddTransient<ITreeFactory , TreeFactory>();
        services.AddTransient<ITreeFlyweightFactory , TreeFlyweightFactory>();
        return services;
    }
}
