using PasswordChecker.Abstractions;
using PasswordChecker.Constants;
using Shared.Services;

namespace PasswordChecker;

/// <summary>
/// PasswordChecker Chain Of Responsibility
/// </summary>
internal class PasswordCheckerCOR(IEnumerable<IPasswordChecker> _checkers) : IPasswordCheckerCOR {

    public void Check(string password) {
        int errCount = 0;
        foreach(var checker in _checkers.OrderBy(x=>x.Order)) {
            if(!checker.Validate(password)) {
                ShowError(checker);
                errCount++;
            }
        }
        if(errCount <= 0) {
            Logger.Log("Good Password!");
        }
    }

    private static void ShowError(IPasswordChecker checker) {
        if(checker.Name == CharacterType.Invalid.Name) {
            Logger.Log($"Error : ({checker.Name}) \n" +
                       $"Your password must does not have any invalid characters\n");
        }
        else {
            Logger.Log($"Error : ({checker.Name}) \n" +
                       $"Your password must have at least {checker.Minimum} {checker.Name} characters\n");
        }
    }

}
