using CoffeeMakerFacade.Abstractions;

namespace CoffeeMakerFacade.Models;

internal class CoffeeBean : IITem {
    public string Name => nameof(CoffeeBean);
}
