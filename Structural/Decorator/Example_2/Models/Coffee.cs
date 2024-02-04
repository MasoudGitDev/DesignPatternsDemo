using Decorator.Example_2.Abstractions;

namespace Decorator.Example_2.Models;
internal class Coffee : IRestaurantOption {
    public decimal Price => 50;

    public string Name => nameof(Coffee) + " , ";
}
