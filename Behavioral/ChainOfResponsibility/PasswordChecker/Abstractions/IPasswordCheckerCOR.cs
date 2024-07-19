namespace PasswordChecker.Abstractions;
/// <summary>
/// IPasswordCheckerCOR use Chain Of Responsibility pattern
/// </summary>
internal interface IPasswordCheckerCOR {
    void Check(string password);
}
