using DesignPatterns.Shared.FactoryPattern.Consts;

namespace DesignPatterns.Shared.FactoryPattern.Abstractions;
public interface IFurnitureFactory {
    IFurniture? Create(FurnitureType furnitureType);
}

