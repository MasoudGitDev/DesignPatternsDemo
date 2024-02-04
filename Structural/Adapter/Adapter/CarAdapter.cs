using Adapter.Abstractions;

namespace Adapter.Adapter;
internal class CarAdapter(Car _car) : Car {
    public override string GetName() => _car.GetName();

    /// <summary>
    /// kmh
    /// </summary>
    public override double GetSpeed() => _car.GetSpeed() * 1.61;

    public override string ToString() => $"{GetName()} : {GetSpeed()} Kmh";
}
