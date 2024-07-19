using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Abstractions;
using ShopManagement.Extensions;
using ShopManagement.Models;

Console.WriteLine("Hello, Chain Of Responsibility Design Pattern!");

var shop = CreateShop();
Console.WriteLine("Shop is Opened");

int amount = 500;
var product = new Pizza(amount);
Console.WriteLine($"I want {amount} {product.Name}!");

shop.Sell(product);

Console.ReadLine();




static ServiceProvider BuildServiceProvider() {
    var serviceCollection = new ServiceCollection();
    serviceCollection.AddShopServices();
    return serviceCollection.BuildServiceProvider();
}

static IShopManager CreateShop() {
    return BuildServiceProvider().GetService<IShopManager>() ??
        throw new InvalidOperationException("No Shop service found.");
}