using DesignPatterns.Shared.BuilderPattern.Abstractions;
using DesignPatterns.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.BuilderPattern.Houses {
    public class NormalHouse : IHouseBuilder {
        public string HouseName { get; set; } = "Normal-House";

        public void CreateFoundation() {
            LogService.Log($"Create {HouseName} House Foundation.");
        }

        public void CreateRoofs() {
            LogService.Log($"Create {HouseName} House Roofs.");
        }

        public void CreateWalls() {
            LogService.Log($"Create {HouseName} walls with bricks.");
        }
    }
}
