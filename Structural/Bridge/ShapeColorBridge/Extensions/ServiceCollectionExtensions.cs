using Microsoft.Extensions.DependencyInjection;
using ShapeColorBridge.Abstractions;
using ShapeColorBridge.Colors;
using ShapeColorBridge.Factory;
using ShapeColorBridge.Models.Colors;
using ShapeColorBridge.Models.Shapes;
using ShapeColorBridge.Shapes;

namespace ShapeColorBridge.Extensions;
public static class ServiceCollectionExtensions {
    public static ServiceCollection AddShapeColors(this ServiceCollection services) {
        services.AddTransient<IColor , BlueColor>();
        services.AddTransient<IColor , RedColor>();
        services.AddTransient<Shape , Circle>();
        services.AddTransient<Shape , Square>();
        services.AddScoped<IColorFactory , ColorFactory>();
        return services;
    }
}
