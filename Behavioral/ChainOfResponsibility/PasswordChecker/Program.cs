using Microsoft.Extensions.DependencyInjection;
using PasswordChecker.Abstractions;
using PasswordChecker.Constants;
using PasswordChecker.Extensions;

Console.WriteLine("Hello Chain Of Responsibility!\n");
Console.WriteLine("Valid characters : " + CharacterType.Valid.Pattern + "\n");

string password = "M*as/K123";
Console.WriteLine($"Your password is : {password}\n");

var passwordChecker = CreatePasswordChecker();
passwordChecker.Check(password);

Console.ReadLine();

//=======================================================
static IServiceProvider CreateProvider() {
    var services = new ServiceCollection();
    services.AddPasswordCheckerServices();
    return services.BuildServiceProvider();
}

static IPasswordCheckerCOR CreatePasswordChecker() {
    return CreateProvider().GetService<IPasswordCheckerCOR>() ?? throw new Exception("System Can not find your service");
}