using DesignPatterns.Shared.Abstractions;
using DesignPatterns.Shared.BuilderPattern.Directors;
using DesignPatterns.Shared.BuilderPattern.Extensions;
using DesignPatterns.Shared.BuilderPattern.Houses;
using DesignPatterns.Shared.Services;

namespace DesignPatterns.Shared.BuilderPattern {

    public class HowToUse : IHowToUse {
        public void MakeExample() {

            // Create Normal House
            new HouseCreator(new NormalHouse()).Create();

            LogService.Log("\n");

            // create Stone House with simple option:
            new HouseCreator(new StoneHouse()).Create().Paint();

            LogService.Log("\n");

            // create Luxury House with full options:
            var luxuryHouse =  new HouseCreator(new LuxuryHouse());
            new HouseDecorator(luxuryHouse).Decorate();

            
            


        }
    }
}
