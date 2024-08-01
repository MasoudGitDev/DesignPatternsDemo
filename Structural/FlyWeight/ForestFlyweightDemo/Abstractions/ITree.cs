using ForestFlyweightDemo.Constants;

namespace ForestFlyweightDemo.Abstractions;

/// <summary>
/// To have extrinsic state
/// </summary>
internal interface ITree {
    public TreeName Name { get; }
    string CreatePositions(double x , double y);
}
