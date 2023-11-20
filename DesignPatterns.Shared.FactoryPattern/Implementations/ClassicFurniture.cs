
using DesignPatterns.Shared.FactoryPattern.Abstractions;
using DesignPatterns.Shared.FactoryPattern.Models.Classic;

namespace DesignPatterns.Shared.FactoryPattern.Implementations;
public class ClassicFurniture : IFurniture {

    public IChair ChooseChair() => new ClassicChair();

    public ISofa ChooseSofa() => new ClassicSofa();

    public ITable ChooseTable() => new ClassicTable();
}
