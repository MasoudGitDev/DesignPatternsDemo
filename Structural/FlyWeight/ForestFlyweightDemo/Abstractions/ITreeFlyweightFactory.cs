using ForestFlyweightDemo.Constants;

namespace ForestFlyweightDemo.Abstractions;

internal interface ITreeFlyweightFactory {
    int Count { get; }
    ITree? GetOrCreate(TreeName name);
}
