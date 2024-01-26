using Strategy.Abstractions;
using Strategy.Constants;

namespace Strategy.Operations;

internal class Subtract: IMathOperation {
    public MathOperationType MathOperationType => MathOperationType.Subtract;
    public double Calculate(double firstNumber , double secondNumber) => firstNumber - secondNumber;
}
