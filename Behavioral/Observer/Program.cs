// See https://aka.ms/new-console-template for more information
using Observer.Observables;
using Observer.Observers;

Console.WriteLine("Hello, World!");


var weatherStation = new WeatherStation();
weatherStation.NotifyAll();

Console.WriteLine(" ==============Register Some Observers ========= \n");
var newsAgency = new NewsAgency("YJC");
var person1 = new Person("Masoud1");
var person2 = new Person("Masoud2");
weatherStation.Register(newsAgency, person1, person2);

Console.WriteLine(" ==============Change Temperature to 32 ========= \n");
weatherStation.Temperature = 32;

Console.WriteLine(" ==============Remove Person 2 : Masoud2 =========\n");
weatherStation.Unregister(person2);

Console.WriteLine(" ==============Change Temperature to 28 =========\n");
weatherStation.Temperature = 28;

Console.WriteLine(" ==============Register Person 2 : Masoud2 =========\n");
weatherStation.Register
    (person2);

Console.WriteLine(" ==============Done =========");
//weatherStation.NotifyAll();

