using ShapeFactoryDemo.Abstractions;
using ShapeFactoryDemo.Constants;
using ShapeFactoryDemo.Exceptions;

namespace ShapeFactoryDemo.Creation;
internal class ShapeFactory(IEnumerable<IShape> shapes) : IShapeFactory {
    //====================
    public IShape Create(ShapeNames shapeName) {
        var shape = shapes.Where(x=> 
            x.Name.Contains(shapeName.ToString() ,StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
        return shape is null ? throw new ShapeException((int) shapeName) : shape;
    }
    public int ShapeCounts => shapes.Count();
}
