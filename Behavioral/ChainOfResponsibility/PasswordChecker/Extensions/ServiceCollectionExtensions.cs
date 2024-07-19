using Microsoft.Extensions.DependencyInjection;
using PasswordChecker.Abstractions;
using PasswordChecker.Checkers;
using PasswordChecker.Constants;

namespace PasswordChecker.Extensions;
internal static class ServiceCollectionExtensions {

    public static ServiceCollection AddPasswordCheckerServices(this ServiceCollection services) {

        services.AddScoped<IPasswordChecker , InvalidCharChecker>(_ => new InvalidCharChecker(0));
        services.AddScoped<IPasswordChecker , CharacterChecker>(_ => new CharacterChecker(CharacterType.Valid , 1 , 8));
        services.AddScoped<IPasswordChecker , CharacterChecker>(_ => new CharacterChecker(CharacterType.English , 2 , 4));
        services.AddScoped<IPasswordChecker , CharacterChecker>(_ => new CharacterChecker(CharacterType.UpperCase , 3 , 2));
        services.AddScoped<IPasswordChecker , CharacterChecker>(_ => new CharacterChecker(CharacterType.LowerCase , 4 , 2));
        services.AddScoped<IPasswordChecker , CharacterChecker>(_ => new CharacterChecker(CharacterType.Digit , 5, 2));
        services.AddScoped<IPasswordChecker , CharacterChecker>(_ => new CharacterChecker(CharacterType.Specials , 6 , 2));
       

        services.AddScoped<IPasswordCheckerCOR , PasswordCheckerCOR>();

        return services;
    }

}
