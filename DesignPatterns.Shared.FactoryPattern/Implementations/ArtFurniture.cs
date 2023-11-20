
using DesignPatterns.Shared.FactoryPattern.Abstractions;
using DesignPatterns.Shared.FactoryPattern.Models.Art;

namespace DesignPatterns.Shared.FactoryPattern.Implementations {
    internal class ArtFurniture : IFurniture {
        public IChair ChooseChair() => new ArtChair();

        public ISofa ChooseSofa() => new ArtSofa();

        public ITable ChooseTable() => new ArtTable();
    }
}
