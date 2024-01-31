using Command.Abstraction;
using Command.Logger;
using Command.Receivers;

namespace Command.Commands;
internal record class IncreasePriceCommand(Product product , decimal amount) : IProductCommand {
    public decimal CurrentPrice => product.Price.Sell;
    public void Execute() {
        decimal price = product.Price.Sell;
        product.IncreasePrice(amount);
        LogController.Log($"Increased price from {price} to {product.Price.Sell}\n");
    }

    public void Undo() {
        decimal price = product.Price.Sell;
        product.DecreasePrice(amount);
        LogController.Log($"Undo : Back to Last price :{price}\n");
    }
}
