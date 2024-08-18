using CoffeeMakerFacade.Abstractions;
using CoffeeMakerFacade.Models;
using Shared.Services;

namespace CoffeeMakerFacade;

internal class CoffeeMaker(
    IGrinder grinder ,
    IHeater heater ,
    IMixer mixer ,
    IFilter filter
    ) : ICoffeeMaker {
    public void Make() {
        grinder.Grind(1);
        heater.Heat(100);
        mixer.Mix(new Water() , new CoffeeBean());
        filter.Filter();
        Logger.Log("The Coffee is ready");
    }
}
