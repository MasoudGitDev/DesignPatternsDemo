using Builder.Houses;
using Shared.Services;

namespace Builder.Builders;
internal class LuxuryHouseBuilder : NormalHouseBuilder {

    public LuxuryHouseBuilder(NormalHouse _normalHouse) : base(_normalHouse) {
    }
    public override LuxuryHouse Build() {       
        var normalHouse = base.Build();
        var luxuryHouse = new LuxuryHouse(normalHouse);
        luxuryHouse.Paint();
        luxuryHouse.Furnished();
        return luxuryHouse;
    }
}
