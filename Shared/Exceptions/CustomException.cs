namespace Shared.Exceptions;
public class CustomException :Exception {
    public string Method { get; } = "<undefined>";
    public string Code { get; } = "<undefined>";
    public string Description { get; }
    public CustomException() : base() {
        Description = Message;
    }
    public CustomException(string description) : base(description) {
        Description = description;
    }
    public CustomException(string code , string description)
        :base($"Code : {code} | Description : {description}")
    {
        Code = code;
        Description = description;
    }
    public CustomException(string method,string code , string description) 
        : base($"Method : {method} | Code : {code} | Description : {description}") {
        Method = method;
        Code = code;
        Description = description;
    }


}
