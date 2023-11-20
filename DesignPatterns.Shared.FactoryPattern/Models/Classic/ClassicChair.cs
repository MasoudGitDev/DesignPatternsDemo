using DesignPatterns.Shared.FactoryPattern.Abstractions;
using DesignPatterns.Shared.Services;

namespace DesignPatterns.Shared.FactoryPattern.Models.Classic;
public class ClassicChair : IChair {
    public void TakeSeat() {
        LogService.Log("Please Sit On This (Classic) Chair!");
    }
}
