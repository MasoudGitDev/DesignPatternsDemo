using ForestFlyweightDemo.Abstractions;
using ForestFlyweightDemo.Constants;

namespace ForestFlyweightDemo.Factory;
internal class TreeFactory(IEnumerable<ITree> trees) : ITreeFactory {
    public ITree? Create(TreeName treeName) {
        return trees.FirstOrDefault(x => x.Name == treeName);
    }
}
