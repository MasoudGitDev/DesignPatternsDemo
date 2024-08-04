// See https://aka.ms/new-console-template for more information
using DatabaseProxyDemo.Abstractions;
using DatabaseProxyDemo.Extensions;
using DatabaseProxyDemo.Models;
using Microsoft.Extensions.DependencyInjection;
using Shared.Services;

Console.WriteLine("Hello, Proxy Design Pattern! \n");

IDatabase db = GetDatabase();

Logger.CreateTitle("Try to find a user with login info {userName=Ali , password:Ali123}");
var dbProxy = new DatabaseProxy(db , new("Ali" , "ALi123/"));
dbProxy.GetUserByName("UserName_1");

Logger.NextLine();
Console.WriteLine("=====Try to get all users with valid user ({userName=UserName_1 , password:Password_1})====\n");
dbProxy = new DatabaseProxy(db , new("UserName_1" , "Password_1"));
dbProxy.GetUsers();





//==================== 
static IDatabase GetDatabase() {
    var services = new ServiceCollection();
    services.AddProxyServices();
    var provider = services.BuildServiceProvider();
    return provider.GetService<IDatabase>() ?? throw new Exception("Can not find the db.");
}