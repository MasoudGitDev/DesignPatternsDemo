using Strategy.Abstractions;
using Strategy.Constants;
using Strategy.Exceptions;
using Strategy.Extensions;
using Strategy.Models;
using System.Reflection;

namespace Strategy;
public class MathOperationFactory {
    public static IMathOperation Create(MathOperationType operationType , double firstNumber , double secondNumber) {
        try {

            var findType = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x=> !x.IsInterface && !x.IsAbstract && x.IsAssignableTo(typeof(IMathOperation)) && x.Name.Contains(operationType.ToString()))           
            .FirstOrDefault()
            .CheckNullability(new ExceptionModel(nameof(Create) ,  "NotFound" , "Can not find the proper type"));

            var instance = Activator.CreateInstance(findType , [firstNumber , secondNumber]) as IMathOperation;
            if(instance == null) {
                throw new MathOperationFactoryException("create" , "NullObj" , $"Can not create instance of {findType.Name} type.");
            }
            return instance;
        }
        catch (Exception ex) {
            throw new MathOperationFactoryException(ex.Message);
        }
    }

    public static IEnumerable<MathOperationModel> CreateTypes() {
        var mathOperationTypes = GetMathOperationTypes();
        foreach(var mathOperationType in mathOperationTypes) {
            var instance = (Activator.CreateInstance(mathOperationType) as IMathOperation)
                .CheckNullability(new ExceptionModel("CreateTypes" , "NullObj" , $"Can not create instance of {mathOperationType.Name} type."));
            
            yield return new MathOperationModel(instance.MathOperationType , instance);
        }
    }

    public static List<Type> GetMathOperationTypes() {
        try {
            var mathOperationTypes = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x=> !x.IsInterface && !x.IsAbstract && x.IsAssignableTo(typeof(IMathOperation)))
            .ToList()
            .CheckNullability(new ExceptionModel (nameof(GetMathOperationTypes),"NotFound" , "Can not find any implementation of IMathOperation"));            
            return mathOperationTypes;
        }
        catch (Exception ex) {
            throw new MathOperationFactoryException(ex.Message);
        }
    }
}
