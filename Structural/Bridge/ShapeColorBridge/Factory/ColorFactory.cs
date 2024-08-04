using ShapeColorBridge.Abstractions;
using ShapeColorBridge.Constants;

namespace ShapeColorBridge.Factory;

internal class ColorFactory(IEnumerable<IColor> shapes) : IColorFactory {
    public IColor Create(ColorName name) => shapes.First(x => x.ColorName == name);
}
