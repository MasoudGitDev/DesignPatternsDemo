namespace ShapeColorBridge.Constants;

public record ShapeName(string Name) {
    public static ShapeName Circle = new(nameof(Circle));
    public static ShapeName Square = new(nameof(Square));
}