using ShapeColorBridge.Constants;

namespace ShapeColorBridge.Abstractions;

public interface IColorFactory {
    public IColor Create(ColorName name);
}