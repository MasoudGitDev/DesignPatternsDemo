using Decorator.Example_1.Abstractions;

namespace Decorator.Example_1.Models;
internal class LiveTV : FlyOption
{

    public LiveTV() : base() { }
    public LiveTV(IFlyOption flyOption) : base(flyOption) { }
    public override string GetName() => _flyOption.GetName() + " LiveTV , ";

    public override decimal GetPrice() => _flyOption.GetPrice() + 100;
}
