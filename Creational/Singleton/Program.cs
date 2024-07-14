using Singleton.Objects;

Console.WriteLine("Hello, Singleton Pattern!\n");

Console.WriteLine("================== Compare HashCodes for Normal Objects\n");
var normalClass1 = new NormalObject();
var normalClass2 = new NormalObject();
Console.WriteLine($"{normalClass1.GetHashCode()} != {normalClass2.GetHashCode()} => Hash codes are different.\n");

Console.WriteLine("Because every time we use the 'new' keyword, it creates a new object.\n");

Console.WriteLine("================== Compare HashCodes for Singleton Objects\n");
var singletonObj1 = SingletonObject.GetOrCreate();
var singletonObj2 = SingletonObject.GetOrCreate();
Console.WriteLine($"{singletonObj1.GetHashCode()} == {singletonObj2.GetHashCode()} => Hash codes are equal.\n");  

Console.WriteLine("Because with the GetOrCreate() method, it checks if the object exists first.\n"); 
Console.WriteLine("If the object exists, it returns it. Otherwise, it creates a new one.\n");

