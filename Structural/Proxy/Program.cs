using Proxy.Models;
using Proxy.Proxy;
using Shared.Services;

Console.WriteLine("Hello, Proxy Pattern! \n");


var proxy = new SecureDbProxy();

Logger.CreateTitle("Get Persons with invalid token == test");
proxy.GetPersonsByToken("test");


Logger.CreateTitle("Get Persons with valid token == token");
proxy.GetPersonsByToken("token");


Logger.CreateTitle("Add new Person with valid token == token");
proxy.CreatePerson("token" , new Person("Person4"));


