using Strategy.Abstractions;
using Strategy.Constants;

namespace Strategy.Operations;

internal class Multiply: IMathOperation {
    public MathOperationType MathOperationType => MathOperationType.Multiply;

    public double Calculate(double firstNumber , double secondNumber) => firstNumber * secondNumber;
}
