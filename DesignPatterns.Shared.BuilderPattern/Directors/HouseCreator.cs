using DesignPatterns.Shared.BuilderPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.BuilderPattern.Directors {
    public class HouseCreator : IHouseCreator
    {
        private readonly IHouseBuilder _houseBuilder;

        public HouseCreator(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public IHouseBuilder Create()
        {

            _houseBuilder.CreateFoundation();
            _houseBuilder.CreateWalls();
            _houseBuilder.CreateRoofs();

            return _houseBuilder;
        }
    }
}
