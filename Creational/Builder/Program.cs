// See https://aka.ms/new-console-template for more information
using Builder.Builders;
using Builder.Houses;
using Shared.Services;

Console.WriteLine("Hello, Builder Pattern! \n");
CreateNormalHouse();
CreateLuxuryHouseBaseOnNormalHouse();
CreateLuxuryHouse();




void CreateNormalHouse() {
    Logger.CreateTitle("I am creating a normal house...");
    var props = new HouseProperties(4,6,4,300);
    var normalHouse = new NormalHouse(props);
    var builder = new NormalHouseBuilder(normalHouse);
    builder.Build();
    builder.CreateInfo();
}

// Create Normal to Luxury or create Luxury base on normal house.
void CreateLuxuryHouseBaseOnNormalHouse() {
    Logger.CreateTitle("I am creating a luxury house (base on normal house model)...");
    var props = new HouseProperties(5,5,5,300);
    var normalHouse = new NormalHouse(props);
    var builder = new LuxuryHouseBuilder(normalHouse);
    builder.Build();
    builder.CreateInfo();
}

void CreateLuxuryHouse() {
    Logger.CreateTitle("I am creating a luxury house 2 (base on luxury house model)...");
    var props = new HouseProperties(10,20,10,1000);
    var luxuryHouse = new LuxuryHouse(props);
    var builder = new LuxuryHouseBuilder(luxuryHouse);
    builder.Build();
    builder.CreateInfo();
}


