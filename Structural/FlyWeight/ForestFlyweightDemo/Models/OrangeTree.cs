using ForestFlyweightDemo.Abstractions;
using ForestFlyweightDemo.Constants;

namespace ForestFlyweightDemo.Models;
internal class OrangeTree : AbstractTree, ITree {
    public TreeName Name => TreeName.Orange;

    public string CreatePositions(double x , double y) {
        X = x;
        Y = y;
        return ( $"{X} : {Y}" );
    }
}
