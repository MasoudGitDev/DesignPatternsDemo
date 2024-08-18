namespace CoffeeMakerFacade.Abstractions;

internal interface IMixer {
    void Mix(params IITem[] items);
}
