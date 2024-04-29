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
        List<string> checkerNames = [];
        foreach(var checker in _checkers) {
           bool isValid =  checker.Value.Check(password);
            if(!isValid) {
                invalidCounter++;                
                checkerNames.Add(checker.Value.Name);
            }
        }
      LogErrors(invalidCounter, checkerNames);
    }    

    private static void LogErrors(int invalidCounter , List<string> checkerNames) {
        if(invalidCounter > 0) {
            Logger.CreateTitle($"Errors : ({invalidCounter})");
            foreach(var name in checkerNames) {
                Logger.Log(name);
            }
        }
    }
}
