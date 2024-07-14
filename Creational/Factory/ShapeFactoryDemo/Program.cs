// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using ShapeFactoryDemo;
using ShapeFactoryDemo.Abstractions;
using Shared.Services;

var shapeFactory =  RegisterShapeServices();
var total = shapeFactory.ShapeCounts;
Console.WriteLine("Hello, Factory Pattern!");
Logger.CreateTitle($"Please choose a shape number (1 to {total}) to draw it:");

try {
      new ProgramHandler(shapeFactory).CreateShape(total , Console.ReadLine() ?? string.Empty);
}
catch {
    Logger.Log($"Invalid shape number. Please enter a number between 1 and {total}.");
}


static IShapeFactory RegisterShapeServices() {
    var serviceCollection = new ServiceCollection();
    serviceCollection.AddShapeServices(); // Register shape services (assuming this method exists)
    var serviceProvider = serviceCollection.BuildServiceProvider();
    var shapeFactory = serviceProvider.GetService<IShapeFactory>();

    return shapeFactory ?? throw new InvalidOperationException("No IShapeFactory service found.");
}
