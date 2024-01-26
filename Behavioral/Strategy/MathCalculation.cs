using Strategy.Abstractions;
using Strategy.Constants;
using Strategy.Exceptions;
using Strategy.Models;

namespace Strategy;
public class MathCalculation {
    private SortedList<MathOperationType , IMathOperation> _operations  = new();

    private MathCalculation() {
        Parallel.ForEach(MathOperationFactory.CreateTypes() , item => _operations.Add(item.MathOperationType , item.MathOperation));
        if(!_operations.Any()) {
            throw new MathCalculationException(new ExceptionModel("MathCalculation" , "Empty" ,
             $"The <_operations> sortedList is empty."));
        }
    }

    public static MathCalculation Create() => new MathCalculation();

    public double Calculate(MathOperationType mathOperationType , double firstNumber , double secondNumber) {       
        foreach(var operation in _operations) {
            if(operation.Key == mathOperationType) {
                return (operation.Value.Calculate(firstNumber , secondNumber));
            }
        }
        throw new MathCalculationException(new ExceptionModel("MathCalculation.Calculate" , "NotMatched" ,
            $"The {mathOperationType} key not founded in the sortedList."));
    }

}
