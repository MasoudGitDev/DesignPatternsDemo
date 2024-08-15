using Strategy.Example_1.Abstractions;
using Strategy.Example_1.Constants;
using Strategy.Example_1.Exceptions;
using Strategy.Example_1.Models;


namespace Strategy.Example_1.Operations;

internal class Divide : IMathOperation
{
    public MathOperationType MathOperationType => MathOperationType.Divide;
    public double Calculate(double firstNumber, double secondNumber) => secondNumber is 0 ?
        throw new MathCalculationException(new ExceptionModel("Divide.Calculate", "Divided By Zero", "Can not Divide by zero.")) : firstNumber / secondNumber;
}
