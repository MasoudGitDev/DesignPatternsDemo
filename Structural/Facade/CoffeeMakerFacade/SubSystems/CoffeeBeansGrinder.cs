using CoffeeMakerFacade.Abstractions;
using Shared.Services;

namespace CoffeeMakerFacade.SubSystems;

internal class CoffeeBeansGrinder : IGrinder {
    public void Grind(float quantity) {
        Logger.Log($"Grinding {quantity} grams of coffee beans.");
    }
}
