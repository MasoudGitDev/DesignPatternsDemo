using DesignPatterns.Shared.FactoryPattern.Abstractions;
using DesignPatterns.Shared.Services;

namespace DesignPatterns.Shared.FactoryPattern.Models.Classic;  
public class ClassicSofa : ISofa {
    public void TakeSeat() {
        LogService.Log("Put Some Things On This (Classic) Sofa!");
    }
}
