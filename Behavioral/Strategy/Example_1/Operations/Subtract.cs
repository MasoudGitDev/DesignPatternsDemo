using Strategy.Example_1.Abstractions;
using Strategy.Example_1.Constants;

namespace Strategy.Example_1.Operations;

internal class Subtract : IMathOperation
{
    public MathOperationType MathOperationType => MathOperationType.Subtract;
    public double Calculate(double firstNumber, double secondNumber) => firstNumber - secondNumber;
}
