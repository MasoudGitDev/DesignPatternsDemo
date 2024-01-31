using Command.Commands;
using Command.Invokers;
using Command.Receivers;
using Command.ValueObjects;

Console.WriteLine("Hello, Command Design Pattern!\n");

try {
    var invoker = new ProductInvoker();
    var product = new Product("Mobile" , new Price(100,120));
    Console.WriteLine("Mobile - main : 100 , sell : 120\n");


    Console.WriteLine("Command : Increase : 30");
    invoker.SetCommand(new IncreasePriceCommand(product , 30));
    invoker.Invoke();

    Console.WriteLine("Command : Discount : 20 ");
    invoker.SetCommand(new DiscountCommand(product , 20));
    invoker.Invoke();

    Console.WriteLine("Command : Decrease : 140");
    invoker.SetCommand(new DecreasePriceCommand(product , 140));
    invoker.Invoke();

    Console.WriteLine("Command : Increase : 60");
    invoker.SetCommand(new IncreasePriceCommand(product , 60));
    invoker.Invoke();
    Console.WriteLine("======================== result :");
    Console.WriteLine("Stack count : " + invoker._commands.Count());
    Console.WriteLine("Sell price : " + product.Price.Sell);
}
catch (Exception ex) {
    Console.WriteLine(ex.ToString());
}

