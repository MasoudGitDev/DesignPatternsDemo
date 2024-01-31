using Observer.Abstractions;

namespace Observer.Observers;
internal class Person(string _fullName) : IObserver {
    public string Name => _fullName;

    public void Update(IObservable observable) {
        Console.WriteLine($"Hi {_fullName} , The {observable.Name} has new data. \n");
    }
}
