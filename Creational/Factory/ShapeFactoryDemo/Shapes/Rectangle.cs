using ShapeFactoryDemo.Abstractions;
using Shared.Services;

namespace ShapeFactoryDemo.Shapes;

internal class Rectangle : IShape {
    public string Name => nameof(Rectangle);

    public void Draw() {
        Logger.CreateTitle($"This is a {Name} Shape.");
    }
}
