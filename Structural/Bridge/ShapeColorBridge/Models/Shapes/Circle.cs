using ShapeColorBridge.Abstractions;
using ShapeColorBridge.Constants;

namespace ShapeColorBridge.Shapes;
internal class Circle(IColor color) : Shape(color) {
    public override ShapeName ShapeName => ShapeName.Circle;
}
