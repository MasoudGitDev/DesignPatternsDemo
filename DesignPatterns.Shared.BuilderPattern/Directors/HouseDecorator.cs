using DesignPatterns.Shared.BuilderPattern.Abstractions;
using DesignPatterns.Shared.BuilderPattern.Extensions;
using DesignPatterns.Shared.BuilderPattern.Houses;

namespace DesignPatterns.Shared.BuilderPattern.Directors {
    public class HouseDecorator  
    {
        private readonly IHouseCreator _houseCreator;

        public HouseDecorator(IHouseCreator houseCreator) {
            this._houseCreator = houseCreator;
        }

        public void Decorate() {
            var house = _houseCreator.Create();
            house.Paint();
            house.UseFurniture();
        }
    }
}
