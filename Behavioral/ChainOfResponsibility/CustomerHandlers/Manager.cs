using ChainOfResponsibility.Abstractions;
using Shared.Services;

namespace ChainOfResponsibility.CustomerHandlers;

internal class Manager(bool _isPresent = true): ChainSellHandler {
    public override bool IsPresent => _isPresent;
    public override bool Sell(IFood food) {
        if(food.Price <= 4000 && _isPresent) {
            Logger.Log($"The {food.Name} food with {food.Price} was sold by {nameof(Manager)}.");
            return true;
        }
        return false;
    }
}
