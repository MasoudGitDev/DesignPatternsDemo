namespace Singleton.Objects;
/// <summary>
/// This class implements the Singleton design pattern to ensure there is only one instance of SingletonObject throughout the application.
/// </summary>
internal class SingletonObject {
    /// <summary>
    /// The single instance of SingletonObject. This private static field is initialized with a new instance using a private constructor at the time of class declaration.
    /// </summary>
    private static readonly SingletonObject _instance = new();

    /// <summary>
    /// Prevents external code from creating new instances of SingletonObject directly using the 'new' keyword.
    /// </summary>
    private SingletonObject() { }

    /// <summary>
    /// Provides a way to access the single instance of SingletonObject. It simply returns the pre-created instance stored in the _instance field.
    /// </summary>
    public static SingletonObject GetOrCreate() => _instance;
}
