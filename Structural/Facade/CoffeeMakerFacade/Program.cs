using CoffeeMakerFacade.Abstractions;
using CoffeeMakerFacade.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Shared.Services;

Console.WriteLine("Hello, Facade Pattern! \n");


Logger.CreateTitle("Coffee Maker Facade ");
var coffeeMaker = CreateCoffeeMaker();
coffeeMaker.Make();












static ICoffeeMaker CreateCoffeeMaker() {
    var services = new ServiceCollection();
    services.AddCoffeeMakerServices();
    var provider = services.BuildServiceProvider();
    return provider.GetRequiredService<ICoffeeMaker>();
}
