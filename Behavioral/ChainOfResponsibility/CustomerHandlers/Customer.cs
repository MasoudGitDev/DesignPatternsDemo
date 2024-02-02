using ChainOfResponsibility.Abstractions;
using Shared.Services;

namespace ChainOfResponsibility.CustomerHandlers;
internal class Customer(bool _isPresent =true) : ChainSellHandler {
    public override bool IsPresent => _isPresent;
    public override bool Sell(IFood food) {
        if(food.Price <= 1000 && _isPresent) {
            Logger.Log($"The {food.Name} food with {food.Price} was sold by {nameof(Customer)}.");
            return true;
        }
        return false;
    }
}
