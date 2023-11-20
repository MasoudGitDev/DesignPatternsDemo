using DesignPatterns.Shared.FactoryPattern.Abstractions;
using DesignPatterns.Shared.FactoryPattern.Consts;
using DesignPatterns.Shared.FactoryPattern.Exceptions;
using System.Reflection;

namespace DesignPatterns.Shared.FactoryPattern.Factories; 

public class FurnitureFactory :IFurnitureFactory {

    private const string _implementationNamespace = "DesignPatterns.Shared.FactoryPattern.Implementations";
    private const string _endWith = "Furniture";

    public IFurniture? Create(FurnitureType furnitureType) {
        var implTypes = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x=>x.Namespace == _implementationNamespace && typeof(IFurniture).IsAssignableFrom(x))
            .ToList() ?? new List<Type>();
        foreach(Type type in implTypes) {
            if(implTypes.Count() > 0 && type.Name.Replace(_endWith , "") == $"{furnitureType}") {
                return (IFurniture?) Activator.CreateInstance(type);
            }
        }
        throw new UnknownFurnitureException($"I couldn't find any type like {furnitureType}.");
    }
}
