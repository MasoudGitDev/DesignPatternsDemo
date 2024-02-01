using Factory.Abstractions;
using Shared.Services;

namespace Factory.Shapes;
internal class Circle : Shape {
    public override string Name => nameof(Circle);
    public override void Draw() => Logger.Log($"This is a {Name} shape.\n");
}
