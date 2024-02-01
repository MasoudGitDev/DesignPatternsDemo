using Factory.Abstractions;
using Shared.Services;

namespace Factory.Shapes;
internal class Rectangle : Shape {
    public override string Name => nameof(Rectangle);
    public override void Draw() => Logger.Log($"This is a {Name} shape.\n");
}
