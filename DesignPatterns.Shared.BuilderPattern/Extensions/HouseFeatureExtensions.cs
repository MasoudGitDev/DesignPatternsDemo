using DesignPatterns.Shared.BuilderPattern.Abstractions;
using DesignPatterns.Shared.BuilderPattern.Directors;
using DesignPatterns.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.BuilderPattern.Extensions {
    public static class HouseFeatureExtensions {
        public static IHouseBuilder Paint(this IHouseBuilder houseCreator) {
            LogService.Log($"{houseCreator.HouseName} Is Painted.");
            return houseCreator;
        }
        public static IHouseBuilder UseFurniture(this IHouseBuilder houseCreator) {
            LogService.Log($"{houseCreator.HouseName} Is Furnished.");
            return houseCreator;
        }

    }
}
