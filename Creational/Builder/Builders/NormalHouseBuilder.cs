using Builder.Houses;
using Shared.Services;

namespace Builder.Builders;
internal class NormalHouseBuilder(NormalHouse _normalHouse) {

    public virtual NormalHouse Build() {
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
