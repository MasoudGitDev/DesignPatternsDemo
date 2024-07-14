using ShapeFactoryDemo.Abstractions;
using Shared.Services;

namespace ShapeFactoryDemo.Shapes;
internal class Circle : IShape {
    public string Name => nameof(Circle);

    public void Draw() {
        Logger.CreateTitle($"This is a {Name} Shape.");
    }
}