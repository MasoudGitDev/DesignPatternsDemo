using Strategy.Example_1.Abstractions;
using Strategy.Example_1.Constants;

namespace Strategy.Example_1.Operations;
internal class Add : IMathOperation
{
    public MathOperationType MathOperationType => MathOperationType.Add;
    public double Calculate(double firstNumber, double secondNumber) => firstNumber + secondNumber;
}
