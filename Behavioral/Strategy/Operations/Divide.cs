using Strategy.Abstractions;
using Strategy.Constants;

namespace Strategy.Operations;

internal class Divide: IMathOperation {
    public MathOperationType MathOperationType => MathOperationType.Divide;
    public double Calculate(double firstNumber , double secondNumber) => secondNumber is 0 ? throw new DivideByZeroException() : firstNumber / secondNumber;
}
