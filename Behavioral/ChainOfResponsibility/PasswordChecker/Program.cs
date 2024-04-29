// An Example of ChainOfResponsibility (PasswordChecker)

using PasswordChecker;

CheckPassword();


static void CheckPassword() {
    Console.WriteLine("Enter your Password : ");
    string password = Console.ReadLine() ?? "";
    PasswordCheckerHandler.Validate(password);
}

