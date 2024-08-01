using ForestFlyweightDemo.Abstractions;
using ForestFlyweightDemo.Constants;

namespace ForestFlyweightDemo.Models;
internal class LemonTree : AbstractTree, ITree {
    TreeName ITree.Name => TreeName.Lemon;

    public string CreatePositions(double x , double y) {
        X = x;
        Y = y;
        return ( $"{X} : {Y}" );
    }
}
