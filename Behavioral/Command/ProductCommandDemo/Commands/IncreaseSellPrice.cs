using ProductCommandDemo.Abstractions;
using ProductCommandDemo.Models;

namespace ProductCommandDemo.Commands;
internal class IncreaseSellPrice(Product product , decimal amount) : IProductCommand {
    public void Execute() {
        product = product.IncreaseSellPrice(amount);
    }

    public void Undo() {
        product = product.DecreaseSellPrice(amount);
    }
}
