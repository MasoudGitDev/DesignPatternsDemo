using ShapeColorBridge.Abstractions;
using ShapeColorBridge.Constants;

namespace ShapeColorBridge.Models.Shapes;

internal class Square(IColor color) : Shape(color) {
    public override ShapeName ShapeName => ShapeName.Square;
}
