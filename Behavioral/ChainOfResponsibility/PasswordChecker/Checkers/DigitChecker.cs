
using PasswordChecker.Abstractions;
using Shared.Services;

namespace PasswordChecker.Checkers;

internal class DigitChecker(int numbers = 3) : AbstractChecker {
    public override string Name => nameof(DigitChecker);

    public override bool Check(string password) {
        int countDigit = 0;
        for(int i = 0 ; i < password.Length ; i++) {
            if(char.IsDigit(password , i)) {
                countDigit++;
            }
        }
        if(countDigit >= numbers) {
            return true;
        }
        Logger.Log($"Your Password : <{password}> must have atleast <{numbers}> digit characters!");
        return false;
    }

}

