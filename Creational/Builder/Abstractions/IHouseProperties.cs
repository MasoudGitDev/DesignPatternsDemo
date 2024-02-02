namespace Builder.Abstractions;

internal interface IHouseProperties {
     byte Doors { get; }
     byte Windows { get; }
     byte Rooms { get; }
     double Area { get; }
}
