using PasswordChecker.Abstractions;
using PasswordChecker.Constants;
using System.Text.RegularExpressions;

namespace PasswordChecker.Checkers;

internal class InvalidCharChecker(int order = 0) : IPasswordChecker {
    public string Name => CharacterType.Invalid.Name;
    public int Order => order;
    public int Minimum => 0;  // Since we only care about presence of invalid chars

    public bool Validate(string password) => Regex.Matches(password , CharacterType.Invalid.Pattern).Count == 0;
}
