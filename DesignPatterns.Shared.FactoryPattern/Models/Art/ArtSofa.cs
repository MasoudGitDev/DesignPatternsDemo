using DesignPatterns.Shared.FactoryPattern.Abstractions;
using DesignPatterns.Shared.Services;

namespace DesignPatterns.Shared.FactoryPattern.Models.Art;
public class ArtSofa : ISofa {
    public void TakeSeat() {
        LogService.Log("Put Some Things On This (Art) Sofa!");
    }
}

