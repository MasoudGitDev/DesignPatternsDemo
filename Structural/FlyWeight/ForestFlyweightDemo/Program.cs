// See https://aka.ms/new-console-template for more information
using ForestFlyweightDemo.Abstractions;
using ForestFlyweightDemo.Constants;
using ForestFlyweightDemo.Extensions;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, Flyweight Design Pattern!\n");


var flyweightFactory = CreateFlyweightFactory();

Console.WriteLine("\nCreate Orange Trees\n");

for(int i = 1; i <= 10; i++) {
    var tree =  flyweightFactory.GetOrCreate(TreeName.Orange);
    var positions =  tree?.CreatePositions(i,i+1);
    Console.WriteLine(positions);
}

Console.WriteLine("\nCreate Lemon Trees\n");

for(int i = 11 ; i <= 20 ; i++) {
    var tree =  flyweightFactory.GetOrCreate(TreeName.Lemon);
    var positions =  tree?.CreatePositions(i,i+1);
    Console.WriteLine(positions);
}

Console.WriteLine("\nTrees :"  + flyweightFactory.Count);












static ITreeFlyweightFactory CreateFlyweightFactory() {
    var serviceCollection = new ServiceCollection();
    serviceCollection.AddTrees(); 
    var serviceProvider = serviceCollection.BuildServiceProvider();
    var factory = serviceProvider.GetService<ITreeFlyweightFactory>();
    return factory ?? throw new InvalidOperationException("The ITreeFlyweightFactory service not found.");
}
