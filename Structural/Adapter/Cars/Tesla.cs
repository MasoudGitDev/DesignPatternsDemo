using Adapter.Abstractions;

namespace Adapter.Cars;

internal class Tesla : Car {
    public override string GetName() => nameof(Tesla);

    /// <summary>
    /// mph
    /// </summary>
    public override double GetSpeed() => 250;
}
