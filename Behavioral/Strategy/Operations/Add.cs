using Strategy.Abstractions;
using Strategy.Constants;

namespace Strategy.Operations;
internal class Add :IMathOperation{
    public MathOperationType MathOperationType => MathOperationType.Add;
    public double Calculate(double firstNumber , double secondNumber) => firstNumber + secondNumber;
}
