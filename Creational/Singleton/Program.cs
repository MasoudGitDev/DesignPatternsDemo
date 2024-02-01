using Singleton.Objects;

Console.WriteLine("Hello, Singleton Pattern! \n");

Console.WriteLine("================== Compare HashCodes for Normal Objects\n");
var normalClass1 = new NormalObject();
var normalClass2 = new NormalObject();
Console.WriteLine($"{normalClass1.GetHashCode()} != {normalClass2.GetHashCode()} => hash codes are different.\n");
Console.WriteLine("Because every time that we use <new> keyword => this means =>  we try to create a new object!\n");

Console.WriteLine("================== Compare HashCodes for Singleton Objects\n");
var singletonObj1 = SingletonObject.GetOrCreate();
var singletonObj2 = SingletonObject.GetOrCreate();
Console.WriteLine($"{singletonObj1.GetHashCode()} != {singletonObj2.GetHashCode()} => hash codes are equals.\n");
Console.WriteLine("Because every time that we use GetOrCreate() method => this means => ");
Console.WriteLine("if that object is available so get it else create new !");
