using PasswordChecker.Abstractions;
using PasswordChecker.Checkers;
using Shared.Services;

namespace PasswordChecker;
internal class PasswordCheckerHandler {
    private static readonly SortedDictionary<int, AbstractChecker> _checkers = new(){
        {1 , new UpperCaseChecker(2) },
        {2 , new LowerCaseChecker(2) },
        {3 , new DigitChecker(2) },
    };

    public static void Validate(string password) {
        int invalidCounter = 0;
        List<string> checkerName = [];
        foreach(var checker in _checkers) {
           bool isValid =  checker.Value.Check(password);
            if(!isValid) {
                invalidCounter++;                
                checkerName.Add(checker.Value.Name);
            }
        }
        if(invalidCounter > 0) {
            Logger.CreateTitle($"Errors : ({invalidCounter})");
            foreach(var name in checkerName) {                
                Logger.Log(name);
            }
        }
    }
}
