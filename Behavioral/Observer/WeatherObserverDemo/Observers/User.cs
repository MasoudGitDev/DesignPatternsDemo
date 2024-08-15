using Shared.Services;
using WeatherObserverDemo.Abstractions;

namespace WeatherObserverDemo.Observers;
internal record User(string Name) : IObserver {
    public void Update(float temperature , float pressure) {
        Logger.Log($"Dear {Name} ! :\n\t[ Temperature : {temperature} °C | Pressure : {pressure} atm ]\n");
    }
}