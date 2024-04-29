namespace PasswordChecker.Abstractions;
internal abstract class AbstractChecker {
    public abstract string Name { get; }
    public abstract bool Check(string password);
}