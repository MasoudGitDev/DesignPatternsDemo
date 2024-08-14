using ProductCommandDemo.Abstractions;
using ProductCommandDemo.Models;

namespace ProductCommandDemo.Commands;
internal class DecreaseSellPrice(Product product , decimal amount) : IProductCommand {
    public void Execute() {
        product = product.DecreaseSellPrice(amount);
    }

    public void Undo() {
        product = product.IncreaseSellPrice(amount);
    }

}
