namespace Observer.Abstractions;

internal interface IObserver{
    string Name { get; }
    void Update(IObservable observable);
}
