using Factory.Abstractions;
using Shared.Services;

namespace Factory.Shapes;
internal class Square : Shape {
    public override string Name => nameof(Square);
    public override void Draw() => Logger.Log($"This is a {Name} shape.\n");
}
