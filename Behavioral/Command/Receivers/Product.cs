using Command.Abstraction;
using Command.ValueObjects;

namespace Command.Receivers;
public record class Product(string Name , Price Price) : IReceiver {

    public void SetDiscount(decimal amount = 0) {
        if(amount > ( Price.Sell - Price.Main )) {
            throw new Exception($"the amount :{amount} must be less than or equal to (sell-main) : {Price.Sell - Price.Main}.");
        }
        Price.Sell -= amount;

    }
    public void DecreasePrice(decimal amount = 0) {
        if(amount > ( Price.Main )) {
            throw new Exception($"the amount :{amount} must be less than or equal to mainPrice : {Price.Main}.");
        }
        Price.Sell -= amount;
    }
    public void IncreasePrice(decimal amount = 0) {
        Price.Sell += amount;
    }
    public void SetSellPrice(decimal price) {
        Price.Sell = price;
    }
}
