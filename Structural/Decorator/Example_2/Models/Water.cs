using Decorator.Example_2.Abstractions;

namespace Decorator.Example_2.Models;

internal class Water : IRestaurantOption {
    public decimal Price => 10;

    public string Name => nameof(Water)  + " , ";
}
