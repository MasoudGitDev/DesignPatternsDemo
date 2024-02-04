// See https://aka.ms/new-console-template for more information

using Decorator.Example_1.Models;
using Decorator.Example_2.Models;
using Shared.Services;

Console.WriteLine("Hello, Decorator Pattern!\n");

Logger.CreateTitle("Reservation a Fly Seat");
var seat = new Airplane(new LiveTV());
Console.WriteLine(seat);


Logger.CreateTitle("Reservation in restaurant");
var restaurant = new Restaurant(
   new Water() ,
   new Tea() ,
   new Coffee()   
);
Console.WriteLine(restaurant);
