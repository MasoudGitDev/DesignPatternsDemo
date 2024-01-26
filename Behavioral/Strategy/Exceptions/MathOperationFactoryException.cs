namespace Strategy.Exceptions;
public class MathOperationFactoryException : CustomException {
    public MathOperationFactoryException() {
    }

    public MathOperationFactoryException(string message) : base(message) {
    }

    public MathOperationFactoryException(string where , string code , string message) : base(where , code , message) {
    }
}
