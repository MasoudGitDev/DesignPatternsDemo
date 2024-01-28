using Strategy.Constants;
using Strategy.Exceptions;
using Strategy.Models;

namespace Strategy;
public class MathCalculation {
    private readonly IEnumerable<MathOperationModel> mathOperationModels;

    private MathCalculation() {
        mathOperationModels = MathOperationFactory.CreateTypes();
    }

    public static MathCalculation Create() => new MathCalculation();
    public IEnumerable<double> Calculate(MathOperationType mathOperationType , double firstNumber , double secondNumber) {
        foreach(var operation in mathOperationModels) {
            if(operation.MathOperationType == mathOperationType) {
                yield return operation.MathOperation.Calculate(firstNumber , secondNumber);
            }
        }
        throw new MathCalculationException(new ExceptionModel("MathCalculation.Calculate" , "NotMatched" ,
           $"The {mathOperationType} key not founded in the sortedList."));
    }
}
