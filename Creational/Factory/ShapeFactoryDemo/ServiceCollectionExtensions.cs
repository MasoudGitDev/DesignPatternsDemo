using Microsoft.Extensions.DependencyInjection;
using ShapeFactoryDemo.Abstractions;
using ShapeFactoryDemo.Creation;
using ShapeFactoryDemo.Shapes;

namespace ShapeFactoryDemo;
internal static class ServiceCollectionExtensions {

    public static IServiceCollection AddShapeServices(this IServiceCollection services) {
        services.AddTransient<IShapeFactory , ShapeFactory>();
        services.AddTransient<IShape , Circle>();
        services.AddTransient<IShape , Square>();
        services.AddTransient<IShape , Rectangle>();
        return services;
    }

}
