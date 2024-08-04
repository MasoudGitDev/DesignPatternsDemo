using Microsoft.Extensions.DependencyInjection;
using ShapeColorBridge.Abstractions;
using ShapeColorBridge.Constants;
using ShapeColorBridge.Extensions;
using ShapeColorBridge.Models.Shapes;
using ShapeColorBridge.Shapes;
using Shared.Services;

Logger.CreateTitle("Hello, Bridge Pattern!");

Logger.CreateTitle("Blue Circle");

var blueColor = CreateColor(ColorName.Blue);
Shape shape = new Circle(blueColor);
shape?.Draw();

Console.WriteLine("\n");
Logger.CreateTitle("Red Square");

var redColor = CreateColor(ColorName.Red);
shape = new Square(redColor);
shape?.Draw();






static IColor CreateColor(ColorName colorName) {
    var services = new ServiceCollection();
    services.AddShapeColors();
    var provider = services.BuildServiceProvider();
    var colorFactory = provider.GetRequiredService<IColorFactory>();
    return colorFactory.Create(colorName);
}