using ShapeFactoryDemo.Constants;

namespace ShapeFactoryDemo.Abstractions;
internal interface IShapeFactory {
    IShape Create(ShapeNames shapeName);
    int ShapeCounts { get; }
}
