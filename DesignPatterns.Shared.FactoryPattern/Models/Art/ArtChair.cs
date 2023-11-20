using DesignPatterns.Shared.FactoryPattern.Abstractions;
using DesignPatterns.Shared.Services;
namespace DesignPatterns.Shared.FactoryPattern.Models.Art; 
public class ArtChair : IChair {
    public void TakeSeat() {
        LogService.Log("Please Sit On This (Art) Chair!");
    }
}
