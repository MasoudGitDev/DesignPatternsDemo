namespace WeatherObserverDemo.Abstractions;
internal interface IObservable {
    void Register(params IObserver[] observers);
    void Unregister(params IObserver[] observers);
    void NotifyAll();
}