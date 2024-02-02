using Builder.Abstractions;
using Shared.Services;

namespace Builder.Houses;
internal class NormalHouse(IHouseProperties _properties) : IHouse {
    public byte Doors { get => _properties.Doors; }
    public byte Windows { get => _properties.Windows; }
    public byte Rooms { get => _properties.Rooms; }
    public double Area { get => _properties.Area; }
    public void CreateFoundation() => Logger.Log("The Foundation is completed.");
    public void CreateRoofs() => Logger.Log("The Roofs is completed");
    public void CreateWalls() => Logger.Log("The Walls is completed");
}


