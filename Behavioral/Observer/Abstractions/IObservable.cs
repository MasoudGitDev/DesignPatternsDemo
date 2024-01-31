namespace Observer.Abstractions;

internal interface IObservable{
    string Name { get; }
    void Register(params IObserver[] observers);
    void Unregister(params IObserver[] observers);
    void NotifyAll();
}
