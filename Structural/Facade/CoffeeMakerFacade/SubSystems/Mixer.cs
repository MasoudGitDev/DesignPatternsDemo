using CoffeeMakerFacade.Abstractions;
using Shared.Services;

namespace CoffeeMakerFacade.SubSystems;

internal class Mixer : IMixer {
    public void Mix(params IITem[] items) {
        Logger.Log("Mix :");
        foreach(var item in items) { 
            Logger.Log($"\t{item.Name}");
        }
    }
}
