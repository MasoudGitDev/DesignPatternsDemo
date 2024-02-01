using Factory.Abstractions;
using Factory.Constants;
using Factory.Exceptions;
using Shared.Extensions;
using System.Reflection;

namespace Factory.Factory;
internal class ShapeFactory {
    public static Shape Create(string shapeName) {
        Type shapeType = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x=> !x.IsInterface
                && !x.IsAbstract
                && x.IsAssignableTo(typeof(Shape)) 
                && x.Name.ToLower().Contains(shapeName))
            .FirstOrDefault().IfNull<ShapeFactoryException,Type>($"System can not find <{shapeName}> shape.");
        return ( Activator.CreateInstance(shapeType) as Shape )
            .IfNull<ShapeFactoryException , Shape>($"System can not create <{shapeName}> shape.");
    }
}
