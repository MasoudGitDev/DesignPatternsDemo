using ChainOfResponsibility;
using ChainOfResponsibility.Models;

Console.WriteLine("Hello, Chain Of Responsibility Pattern!\n");

var food = new Food("Apple" , 100);
Shop.Sell(food);
