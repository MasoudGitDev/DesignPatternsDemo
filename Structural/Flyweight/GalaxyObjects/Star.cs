using Flyweight.Abstractions;
using Shared.Services;

namespace Flyweight.GalaxyObjects;
internal class Star : IGalaxyObject {

    private readonly BasicObject _object = new BasicObject(Constants.GalaxyObject.Star , "Red");
    private decimal xPos = 0;
    private decimal yPos = 0;
    public void SetPositions(decimal x , decimal y) {
        xPos = x;
        yPos = y;
    }

    public override string ToString() {
        return $"({_object.GalaxyObject} : {_object.Color}) : ([x : {xPos}] , [y : {yPos}])\n";
    }
}
internal class Planet : IGalaxyObject {

    private readonly BasicObject _object = new BasicObject(Constants.GalaxyObject.Planet , "Blue");
    private decimal xPos = 0;
    private decimal yPos = 0;
    public void SetPositions(decimal x , decimal y) {
        xPos = x;
        yPos = y;
    }

    public override string ToString() {
        return $"({_object.GalaxyObject} : {_object.Color}) : ([x : {xPos}] , [y : {yPos}])\n";
    }

}

