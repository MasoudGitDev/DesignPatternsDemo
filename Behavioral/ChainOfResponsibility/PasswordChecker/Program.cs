using Shared.Services;
using PasswordChecker;


Logger.CreateTitle("An Example of ChainOfResponsibility (PasswordChecker)");


CheckPassword();


static void CheckPassword() {
    Console.WriteLine("Enter your Password : ");
    string password = Console.ReadLine() ?? "";
    PasswordCheckerHandler.Validate(password);
}

