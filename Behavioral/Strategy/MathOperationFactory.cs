using Strategy.Abstractions;
using Strategy.Exceptions;
using Strategy.Extensions;
using Strategy.Models;
using System.Reflection;

namespace Strategy;
public class MathOperationFactory {

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
        catch(Exception ex) {
            throw new MathOperationFactoryException(ex.Message);
        }
    }
}
