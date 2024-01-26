using Strategy.Models;

namespace Strategy.Exceptions;
public class CustomException : Exception {
    public string Where { get; } = "Unknown";
    public string Code { get; } = "Unknown";
    private static string newLine => Environment.NewLine;

    public CustomException() {}
    public CustomException(string message) : base(message) {}
    public CustomException(string where , string code , string message) :
        base($"Where : {where}{newLine}Code : {code}{newLine}Message : {message}{newLine}") {
        Where = where;
        Code = code;
    }
    public CustomException(ExceptionModel model) :
        base($"Where : {model.Where}{newLine}Code : {model.Code}{newLine}Message : {model.Message}{newLine}") {
        Where = model.Where;
        Code = model.Code;
    }
}
