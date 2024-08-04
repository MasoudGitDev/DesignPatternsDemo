using ShapeColorBridge.Constants;

namespace ShapeColorBridge.Abstractions;
public interface IColor {
    ColorName ColorName { get; }
    void Apply();
}