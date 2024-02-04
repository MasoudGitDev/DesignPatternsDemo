// See https://aka.ms/new-console-template for more information
using Adapter.Adapter;
using Adapter.Cars;
using Adapter.Extensions;

Console.WriteLine("Hello, Adapter Pattern! \n");

var bmw = new BMW();
Console.WriteLine("Main : " + bmw);

var bmwAdapter = new CarAdapter(bmw);
Console.WriteLine("BMW-Adapter : " + bmwAdapter + "\n");

var tesla = new Tesla();
Console.WriteLine("Main : " + tesla);

var teslaAdapter = tesla.AsStandard();
Console.WriteLine("Tesla-Adapter : " + teslaAdapter);
