using ChainOfResponsibility.Abstractions;
using Shared.Services;

namespace ChainOfResponsibility.CustomerHandlers;

internal class Owner(bool _isPresent = true) : ChainSellHandler {
    public override bool IsPresent => _isPresent;
    public override bool Sell(IFood food) {
        if(food.Price <= 10000 && _isPresent) {
            Logger.Log($"The {food.Name} food with {food.Price} was sold by {nameof(Owner)}.");
            return true;
        }
        Logger.Log("Please prepare a meeting.");
        return false;
    }
}
