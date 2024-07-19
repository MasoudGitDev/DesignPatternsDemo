using PasswordChecker.Abstractions;
using PasswordChecker.Constants;
using System.Text.RegularExpressions;

namespace PasswordChecker.Checkers;

internal class CharacterChecker(CharacterType type , int order = 0 , int minimum = 3) : IPasswordChecker {
    public string Name => type.Name;
    public int Order => order;
    public int Minimum => minimum;

    public bool Validate(string password) => Regex.Matches(password , type.Pattern).Count >= minimum;
}
