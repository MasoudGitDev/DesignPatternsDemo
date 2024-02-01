using AbstractFactory.Constants;
using AbstractFactory.Theme;
using Shared.Services;

Console.WriteLine("Hello, Abstract Factory Pattern! \n");

try {
    Logger.CreateTitle("Light Mode Theme");
    var theme = new Theme(ColorMode.Light);
    theme.Show();
    Logger.CreateTitle("Done");
}
catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

