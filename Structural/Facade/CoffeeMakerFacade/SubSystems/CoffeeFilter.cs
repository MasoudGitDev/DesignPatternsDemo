using CoffeeMakerFacade.Abstractions;
using Shared.Services;

namespace CoffeeMakerFacade.SubSystems;

internal class CoffeeFilter : IFilter {
    public void Filter() {
        Logger.Log("Filtering coffee...");
    }
}