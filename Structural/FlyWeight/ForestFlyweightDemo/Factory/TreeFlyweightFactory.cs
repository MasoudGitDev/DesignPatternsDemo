using ForestFlyweightDemo.Abstractions;
using ForestFlyweightDemo.Constants;

namespace ForestFlyweightDemo.Factory;
internal class TreeFlyweightFactory(ITreeFactory treeFactory) : ITreeFlyweightFactory {
    private readonly Dictionary<TreeName , ITree> TreesCache = new();
    public int Count => TreesCache.Count;

    public ITree? GetOrCreate(TreeName name) { 
        if(TreesCache.ContainsKey(name)) {
            return TreesCache[name];
        }
        var tree = treeFactory.Create(name);
        if(tree is null) {
            return tree;
        }
        TreesCache.Add( name, tree);
        return tree;
    }


}
