using Adapter.Abstractions;

namespace Adapter.Cars;
internal class BMW : Car {
    public override string GetName() => nameof(BMW);

    /// <summary>
    /// mph
    /// </summary>
    public override double GetSpeed() => 170;
}
