using DesignPatterns.Shared.FactoryPattern.Factories;
using DesignPatterns.Shared.Services;

namespace DesignPatterns.Shared.FactoryPattern;
public static class HowToUse {

    public static void MakeExample() {
        var furniture = new FurnitureFactory().Create(Consts.FurnitureType.Art);
        furniture?.ChooseChair().TakeSeat();
        furniture?.ChooseSofa().TakeSeat();
        furniture?.ChooseTable().PutItem();
        LogService.Log("Operation is Ended.");
    }
}