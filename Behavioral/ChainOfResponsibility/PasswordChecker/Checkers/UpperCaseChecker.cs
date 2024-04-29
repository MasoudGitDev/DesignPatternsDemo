
using PasswordChecker.Abstractions;
using Shared.Services;

namespace PasswordChecker.Checkers;
internal class UpperCaseChecker(int numbers = 3) : AbstractChecker {
    public override string Name => nameof(UpperCaseChecker);

    public override bool Check(string password) {
        int countUpperCase = 0;
        for(int i = 0 ; i< password.Length ; i++) {
            if(char.IsUpper(password , i)) {
                countUpperCase++;
            }
        }
        if(countUpperCase >= numbers) {
            return true;
        }
        Logger.Log($"Your Password : <{password}> must have atleast <{numbers}> <upper> case alphabet characters!");
        return false;
    }
}