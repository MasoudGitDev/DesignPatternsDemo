using Shared.Services;
using WeatherObserverDemo.Abstractions;

namespace WeatherObserverDemo.Observers;

internal record NewsAgency(string Name) : IObserver {
    public void Update(float temperature , float pressure) {
        Logger.Log($"{Name} News Agency :\n\t[ Temperature : {temperature} °C | Pressure : {pressure} atm ]\n");
    }
}
