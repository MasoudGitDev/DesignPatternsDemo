using Factory.Exceptions;
using Factory.Factory;
using Shared.Services;

Console.WriteLine("Hello, Factory Pattern! \n");

Logger.CreateTitle("Shape names :  Rectangle , Circle or Square  :");
Console.WriteLine("Enter Shape Name : ");
string? shapeName = Console.ReadLine();
try {
    ( ShapeFactory.Create(shapeName ?? "circle") ).Draw();
    Logger.CreateTitle("Done");
}
catch(ShapeFactoryException ex) {
    Console.WriteLine("Error : " + ex.Message);
}

