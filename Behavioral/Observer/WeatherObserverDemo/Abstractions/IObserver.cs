namespace WeatherObserverDemo.Abstractions;

internal interface IObserver {
    string Name { get; }
    void Update(float temperature , float pressure);
}