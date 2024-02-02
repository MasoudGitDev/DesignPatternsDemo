using Builder.Abstractions;

namespace Builder.Houses;

internal record HouseProperties(byte Doors , byte Windows , byte Rooms , double Area) : IHouseProperties;
