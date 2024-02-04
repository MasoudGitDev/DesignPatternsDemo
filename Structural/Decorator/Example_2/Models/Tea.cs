using Decorator.Example_2.Abstractions;

namespace Decorator.Example_2.Models;

internal class Tea : IRestaurantOption {
    public decimal Price => 30;

    public string Name => nameof(Tea) + " , ";
}
