using Builder.Abstractions;
using Shared.Services;

namespace Builder.Houses;

internal class LuxuryHouse : NormalHouse , IHouseOptions {
    public LuxuryHouse(IHouseProperties _properties) : base(_properties) {
    }
    public LuxuryHouse(NormalHouse normalHouse) : base(normalHouse) {

    }

    public void Furnished()=> Logger.Log("The Furnished is completed.");

    public void Paint() => Logger.Log("The Paint is completed.");
}


