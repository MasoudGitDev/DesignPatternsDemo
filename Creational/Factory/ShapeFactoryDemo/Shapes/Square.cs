using ShapeFactoryDemo.Abstractions;
using Shared.Services;

namespace ShapeFactoryDemo.Shapes;

internal class Square : IShape {
    public string Name => nameof(Square);

    public void Draw() {
        Logger.CreateTitle($"This is a {Name} Shape.");
    }
}
