using Command.Abstraction;
using Command.Logger;
using Command.Receivers;
using Command.ValueObjects;

namespace Command.Commands;
internal record class DecreasePriceCommand(Product product , decimal amount) : IProductCommand {
    public decimal CurrentPrice => product.Price.Sell;

    public void Execute() {
        decimal price = product.Price.Sell;
        product.DecreasePrice(amount);
        LogController.Log($"Decreased price from {price} to {product.Price.Sell}\n");
    }

    public void Undo() {        
        decimal price = product.Price.Sell;
        product.IncreasePrice(amount);
        LogController.Log($"Undo : Back to Last price :{price}\n");
    }
}
