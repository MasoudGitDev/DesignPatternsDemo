using ShapeColorBridge.Abstractions;
using ShapeColorBridge.Constants;
using Shared.Services;

namespace ShapeColorBridge.Models.Colors;

internal class BlueColor : IColor {
    public ColorName ColorName => ColorName.Blue;

    public void Apply() {
        Logger.Log($"The {ColorName.Name.ToLower()} Color is applied to the shape.");
    }
}
