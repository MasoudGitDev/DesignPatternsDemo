using Decorator.Example_1.Abstractions;

namespace Decorator.Example_1.Models;
internal class NoFlyOption : IFlyOption
{
    public string GetName() => string.Empty;

    public decimal GetPrice() => 0;
}
