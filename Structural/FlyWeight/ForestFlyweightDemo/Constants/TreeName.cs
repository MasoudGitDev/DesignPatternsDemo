namespace ForestFlyweightDemo.Constants;
internal record TreeName(string Name) {
    public static TreeName None => new("NotTree");
    public static TreeName Lemon => new("Lemon");
    public static TreeName Orange => new("Orange");
}
