using Strategy.Example_1.Abstractions;
using Strategy.Example_1.Constants;

namespace Strategy.Example_1.Operations;

internal class Multiply : IMathOperation
{
    public MathOperationType MathOperationType => MathOperationType.Multiply;

    public double Calculate(double firstNumber, double secondNumber) => firstNumber * secondNumber;
}
