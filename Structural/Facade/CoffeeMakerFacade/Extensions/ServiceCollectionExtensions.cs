using CoffeeMakerFacade.Abstractions;
using CoffeeMakerFacade.Models;
using CoffeeMakerFacade.SubSystems;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeMakerFacade.Extensions;
internal static class ServiceCollectionExtensions {
    public static ServiceCollection AddCoffeeMakerServices(this ServiceCollection services) {

        //========items
        services.AddTransient<IITem , Water>();
        services.AddTransient<IITem , CoffeeBean>();

        //=========== sub systems
        services.AddTransient<IHeater , ElectricWaterHeater>();
        services.AddTransient<IMixer , Mixer>();
        services.AddTransient<IFilter , CoffeeFilter>();
        services.AddTransient<IGrinder , CoffeeBeansGrinder>();

        //system
        services.AddTransient<ICoffeeMaker , CoffeeMaker>();

        return services;
    }
}
