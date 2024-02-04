using Decorator.Example_1.Abstractions;

namespace Decorator.Example_1.Models;
internal class Airplane : FlyOption
{
    public Airplane() : base() { }
    public Airplane(IFlyOption flyOption) : base(flyOption)
    {

    }
    public override string GetName()
    {
        return base.GetName() + " Mahan ,";
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 5000;
    }
}
