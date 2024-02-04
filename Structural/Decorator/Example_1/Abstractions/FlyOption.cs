using Decorator.Example_1.Models;
using System.Text;

namespace Decorator.Example_1.Abstractions;

internal abstract class FlyOption : IFlyOption
{
    protected IFlyOption _flyOption;
    protected FlyOption(IFlyOption flyOption)
    {
        _flyOption = flyOption;
    }
    protected FlyOption()
    {
        _flyOption = new NoFlyOption();
    }

    public virtual decimal GetPrice() => _flyOption.GetPrice();

    public virtual string GetName() => _flyOption.GetName();
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Names : ");
        sb.Append(GetName().Remove(GetName().Length - 2).Trim());
        sb.Append("\n");
        sb.Append("Prices : ");
        sb.Append(GetPrice());
        return sb.ToString();
    }
}

