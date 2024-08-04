using ShapeColorBridge.Abstractions;
using ShapeColorBridge.Constants;
using Shared.Services;

namespace ShapeColorBridge.Colors;
internal class RedColor : IColor {
    public ColorName ColorName => ColorName.Red;

    public void Apply() {
        Logger.Log($"The {ColorName.Name.ToLower()} Color is applied to the shape.");
    }
}