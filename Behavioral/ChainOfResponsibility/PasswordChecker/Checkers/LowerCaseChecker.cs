
using PasswordChecker.Abstractions;
using Shared.Services;

namespace PasswordChecker.Checkers;

internal class LowerCaseChecker(int numbers = 3) : AbstractChecker {
    public override string Name => nameof(LowerCaseChecker);

    public override bool Check(string password) {
        int countLowerCase = 0;
        for(int i = 0 ; i < password.Length ; i++) {
            if(char.IsLower(password , i)) {
                countLowerCase++;
            }
        }
        if(countLowerCase >= numbers) {
            return true;
        }
        Logger.Log($"Your Password : <{password}> must have atleast <{numbers}> <lower> case alphabet characters!");
        return false;
    }

}

