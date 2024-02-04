namespace Adapter.Abstractions;
internal abstract class Car {
    public abstract double GetSpeed();
    public abstract string GetName();

    public override string ToString() => $"{GetName()} : {GetSpeed()} mph";


}
