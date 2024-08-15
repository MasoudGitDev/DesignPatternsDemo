using Shared.Services;
using WeatherObserverDemo.Observers;
using WeatherObserverDemo.Subjects;

Console.WriteLine("Hello, Observer Pattern! \n");

WeatherStation weatherStation = new();

Logger.CreateTitle("Add some observers :");
var observer1 = new User("Masoud1");
var observer2 = new User("Masoud2");
var observer3 = new NewsAgency("YJC");

weatherStation.Register(observer1 , observer2 , observer3);

Logger.NextLine();


Logger.CreateTitle("Remove Masoud2 observer :");
weatherStation.Unregister(observer2);
Logger.NextLine();


Logger.CreateTitle("Temperature has changed :");
weatherStation.SetTemperature(9);


