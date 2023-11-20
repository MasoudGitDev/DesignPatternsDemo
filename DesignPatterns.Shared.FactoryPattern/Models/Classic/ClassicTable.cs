
using DesignPatterns.Shared.FactoryPattern.Abstractions;
using DesignPatterns.Shared.Services;

namespace DesignPatterns.Shared.FactoryPattern.Models.Classic;
public class ClassicTable : ITable {
    public void PutItem() {
        LogService.Log("Put Some Things On This (Classic) Table");
    }
}