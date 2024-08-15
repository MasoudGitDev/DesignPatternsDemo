using Strategy.Example_1.Constants;
using System.Numerics;

namespace Strategy.Example_1.Abstractions;
public interface IMathOperation
{
    double Calculate(double firstNumber, double secondNumber);
    MathOperationType MathOperationType { get; }
}
