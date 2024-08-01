using ForestFlyweightDemo.Constants;

namespace ForestFlyweightDemo.Abstractions;
internal interface ITreeFactory {
    ITree? Create(TreeName treeName);
}