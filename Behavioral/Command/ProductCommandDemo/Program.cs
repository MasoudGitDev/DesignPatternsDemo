using ProductCommandDemo.Commands;
using ProductCommandDemo.Invoker;
using ProductCommandDemo.Models;
using Shared.Services;

Console.WriteLine("Hello, Command Pattern !\n");

Logger.CreateTitle("Create a new product : ");
var product = Product.New("Mobile X" , 100 , 110);
Logger.Log(product.ToString() + "\n");

//----------------------------------- create invoker
var productInvoker = new ProductInvoker();

Logger.CreateTitle("Decrease price : 50 : ");
productInvoker.SetCommand(new DecreaseSellPrice(product , 50));
productInvoker.Invoke();
productInvoker.Undo();

Logger.NextLine();

Logger.CreateTitle("Increase price : 100 : ");
productInvoker.SetCommand(new IncreaseSellPrice(product , 100));
productInvoker.Invoke();
productInvoker.Undo();


Logger.NextLine();

Logger.CreateTitle("Set Discount  : 5% : ");
productInvoker.SetCommand(new PriceDiscount(product , 5));
productInvoker.Invoke();
productInvoker.Undo();





