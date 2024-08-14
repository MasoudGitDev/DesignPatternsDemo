using ProductCommandDemo.Abstractions;
using ProductCommandDemo.Models;

namespace ProductCommandDemo.Commands;
internal class PriceDiscount(Product product , decimal percentage) : IProductCommand {
    public void Execute() {
        product = product.SetDiscount(percentage);
    }

    public void Undo() {
        product = product.PopDiscount(percentage);
    }
}
