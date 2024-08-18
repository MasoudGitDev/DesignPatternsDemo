using CoffeeMakerFacade.Abstractions;
using Shared.Services;

namespace CoffeeMakerFacade.SubSystems;
internal class ElectricWaterHeater : IHeater {
    public void Heat(float temperature) {
        Logger.Log($"Water heated to {temperature} degrees Celsius.");
    }
}