using Strategy.Models;

namespace Strategy.Exceptions;
public class MathCalculationException : CustomException {
    public MathCalculationException() {
    }

    public MathCalculationException(string message) : base(message) {
    }

    public MathCalculationException(ExceptionModel model) : base(model) {
    }

    public MathCalculationException(string where , string code , string message) : base(where , code , message) {
    }
}
