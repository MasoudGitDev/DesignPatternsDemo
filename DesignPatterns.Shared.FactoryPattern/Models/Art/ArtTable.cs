
using DesignPatterns.Shared.FactoryPattern.Abstractions;
using DesignPatterns.Shared.Services;

namespace DesignPatterns.Shared.FactoryPattern.Models.Art;
public class ArtTable : ITable {
    public void PutItem() {
        LogService.Log("Put Some Things On This (Art) Table");
    }
}
