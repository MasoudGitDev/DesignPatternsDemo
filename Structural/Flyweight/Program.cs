// See https://aka.ms/new-console-template for more information
using Flyweight;
using Flyweight.Constants;
using Shared.Services;

Console.WriteLine("Hello, Flyweight Pattern!\n");

try {
    Logger.CreateTitle("Star");
    var start1 = GalaxyFlyweightFactory.GetOrCreate(GalaxyObject.Star);
    start1.SetPositions(10 , 20);
    start1.ToString();

    var start2 = GalaxyFlyweightFactory.GetOrCreate(GalaxyObject.Star);
    start2.SetPositions(60 , 50);

    var start3 = GalaxyFlyweightFactory.GetOrCreate(GalaxyObject.Star);
    start3.SetPositions(100 , 80);

    Logger.CreateTitle("Planet");
    var planet1 = GalaxyFlyweightFactory.GetOrCreate(GalaxyObject.Planet);
    planet1.SetPositions(200 , 50);

    var planet2 = GalaxyFlyweightFactory.GetOrCreate(GalaxyObject.Planet);
    planet2.SetPositions(200 , 80);

    Logger.CreateTitle("Number of Creation");
    GalaxyFlyweightFactory.GetCount();
}
catch(Exception ex) {
    Logger.Log(ex.Message);
}

