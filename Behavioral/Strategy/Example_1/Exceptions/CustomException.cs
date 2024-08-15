using Strategy.Example_1.Models;
using System.Text.Json;

namespace Strategy.Example_1.Exceptions;
public class CustomException : Exception
{
    public string Where { get; } = "Unknown";
    public string Code { get; } = "Unknown";
    private static string newLine => Environment.NewLine;

    public CustomException() { }
    public CustomException(string message) : base(message) { }
    public CustomException(string where, string code, string message) :
        base($"Where : {where}{newLine}Code : {code}{newLine}Message : {message}{newLine}")
    {
        Where = where;
        Code = code;
    }
    public CustomException(ExceptionModel model) : base(ToJson(model))
    {
        Where = model.Where;
        Code = model.Code;
    }

    public static string ToJson(ExceptionModel model)
    {
        return JsonSerializer.Serialize(model);
    }
    public override string ToString()
    {
        string writeException =
            Environment.NewLine + "Where : " + Where +
            Environment.NewLine + "Code : " + Code +
            Environment.NewLine + "Message : " + Message +
            Environment.NewLine;
        return writeException;
    }
}
