namespace PasswordChecker.Abstractions;
internal interface IPasswordChecker {
    int Minimum {  get; }
    int Order { get; }
    string Name { get; }
    bool Validate(string password);
}
