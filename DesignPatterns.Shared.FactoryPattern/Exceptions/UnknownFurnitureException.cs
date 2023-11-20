namespace DesignPatterns.Shared.FactoryPattern.Exceptions; 
public class UnknownFurnitureException : Exception {
    public UnknownFurnitureException(string message) : base(message) { }
}
