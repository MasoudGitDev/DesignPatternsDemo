using Observer.Abstractions;

namespace Observer.Observables;
internal class WeatherStation : IObservable {
    public string Name => nameof(WeatherStation);

    private double _temperature = 10;
    public double Temperature { 
        get => _temperature;
        set {
            _temperature = value;
            NotifyAll();
          }
    }
    private LinkedList<IObserver> _observers = new();

    public void NotifyAll() {
        Parallel.ForEach(_observers , item => item.Update(this));
    }
    public void Unregister(params IObserver[] observers) {
        foreach(var observer in observers) {
            _observers.Remove(observer);
            Console.WriteLine($"Observer {observer.Name} was removed.\n");
        }     
    }

    public void Register(params IObserver[] observers) {
        foreach (var observer in observers) {
            _observers.AddLast(observer);
            Console.WriteLine($"New observer {observer.Name} was added.\n");
        }
    }
}
