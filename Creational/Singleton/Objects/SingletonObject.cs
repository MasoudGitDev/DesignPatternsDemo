namespace Singleton.Objects;
internal class SingletonObject {
    private static readonly SingletonObject _instance =new();
    private SingletonObject() { }
    public static SingletonObject GetOrCreate() => _instance;
}
