using Shared.Services;
using WeatherObserverDemo.Abstractions;

namespace WeatherObserverDemo.Subjects;
internal class WeatherStation : IObservable {

    private readonly LinkedList<IObserver> _observers = [];
    private float _temperature = 10;
    private float _pressure = 1;

    public void SetTemperature(float temperature) {
        if(temperature == _temperature)
            return;
        Logger.Log($"Weather Station : Temperature has been changed : from [{_temperature}] °C to [{temperature}] °C .\n");
        _temperature = temperature;
        NotifyAll();
    }

    public void SetPressure(float pressure) {
        if(pressure == _pressure)
            return;
        Logger.Log($"Weather Station : Pressure has been changed : from [{_pressure}] atm to [{pressure}] atm.\n");
        _pressure = pressure;
        NotifyAll();
    }

    public void NotifyAll() {
        Parallel.ForEach(_observers , observer => {
            observer.Update(_temperature , _pressure);
        });
    }

    public void Register(params IObserver[] observers) {
        foreach(var observer in observers) {
            Logger.Log($"Observer : The {observer.Name} observer has been added.");
            _observers.AddLast(observer);
        }
    }

    public void Unregister(params IObserver[] observers) {
        foreach(var observer in observers) {
            Logger.Log($"Observer : The {observer.Name} observer has been removed.");
            _observers.Remove(observer);
        }
    }
}
