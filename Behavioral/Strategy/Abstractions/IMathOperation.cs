using Strategy.Constants;
using System.Numerics;

namespace Strategy.Abstractions;
public interface IMathOperation{
    double Calculate(double firstNumber , double secondNumber); 
    MathOperationType MathOperationType { get; }
}
