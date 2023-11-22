namespace DesignPatterns.Shared.BuilderPattern.Abstractions {

    public interface IHouse {
        public string HouseName { get; set; }
    }
    public interface IHouseCreator {
        IHouseBuilder Create();
    }
    public interface IHouseBuilder :IHouse{
        void CreateFoundation();
        void CreateWalls();
        void CreateRoofs();
    }

 



}
