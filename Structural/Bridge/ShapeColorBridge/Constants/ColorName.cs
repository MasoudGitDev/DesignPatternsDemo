namespace ShapeColorBridge.Constants;
public record ColorName(string Name) {
    public static ColorName Red = new(nameof(Red));
    public static ColorName Blue = new(nameof(Blue));
}