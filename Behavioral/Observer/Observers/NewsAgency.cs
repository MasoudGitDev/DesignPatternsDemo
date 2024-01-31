using Observer.Abstractions;

namespace Observer.Observers;
internal class NewsAgency(string _name) : IObserver {
    public string Name => _name;

    public void Update(IObservable observable) {
        Console.WriteLine($"{_name} NewsAgency , The {observable.Name} has new data. \n");
    }
}
