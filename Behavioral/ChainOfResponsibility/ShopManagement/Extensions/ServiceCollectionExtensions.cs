using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Abstractions;
using ShopManagement.Managers;
using ShopManagement.Models;

namespace ShopManagement.Extensions;
internal static class ServiceCollectionExtensions {
    public static IServiceCollection AddShopServices(this IServiceCollection services) {
        // Managers
        services.AddTransient<IManager , GeneralManager>();
        services.AddTransient<IManager , HeadChef>();
        services.AddTransient<IManager , PurchasingManager>();

        // Foods
        services.AddTransient<IProduct , Pizza>();
        services.AddTransient<IProduct , Hamburger>();

        // Shop
        services.AddTransient<IShopManager , ShopManager>();

        return services;
    }
}
