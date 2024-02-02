using Builder.Abstractions;
using Shared.Services;

namespace Builder.Builders;
internal class NormalHouseBuilder(IHouse _normalHouse) {

    public virtual IHouse Build() {
        _normalHouse.CreateFoundation();
        _normalHouse.CreateWalls();
        _normalHouse.CreateRoofs();
        return _normalHouse;
    }

    public virtual void CreateInfo() {
        Logger.CreateTitle("House Info :");
        Logger.Log($"Area: {_normalHouse.Area}");
        Logger.Log($"Rooms: {_normalHouse.Rooms}");
        Logger.Log($"Doors: {_normalHouse.Doors}");
        Logger.Log($"Windows: {_normalHouse.Windows}\n");
    }

}
