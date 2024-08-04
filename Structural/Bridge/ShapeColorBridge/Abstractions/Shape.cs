using ShapeColorBridge.Constants;
using Shared.Services;

namespace ShapeColorBridge.Abstractions;

public abstract class Shape(IColor color) {
    public abstract ShapeName ShapeName { get; }

    public virtual void Draw() {
        Logger.Log($"This is a {ShapeName.Name.ToLower()} shape");
        color.Apply();
    }
}
