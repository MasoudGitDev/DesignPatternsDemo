using Strategy.Example_1.Constants;
using Strategy.Example_1.Exceptions;
using Strategy.Example_1.Extensions;
using Strategy.Example_1.Models;
using System.Text.Json;

namespace Strategy.Example_1;
internal class MathProgramExecution
{

    public void Execute()
    {
        bool result = false;
        while (!result)
        {
            result = TryToCalc();
        }

    }
    private bool TryToCalc()
    {
        try
        {
            (bool result, MathOperationType operationType) = ChooseOperation();
            result.IfIsFalse(AskToContinue);
            Calculate(operationType);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
            Console.WriteLine("---------------------------");
            return false;
        }
    }
    private void Calculate(MathOperationType mathOperationType)
    {
        try
        {
            (double firstNumber, double secondNumber) = GetOperationValues();
            var mathContext = MathCalculation.Create();
            var resultValue = mathContext.Calculate(mathOperationType, firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} {mathOperationType} {secondNumber} : {resultValue.First()}");
            Console.WriteLine("Done.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message.ToString());
            Calculate(mathOperationType);
        }
        catch (CustomException ex)
        {
            Console.WriteLine(ex.Message.ToString());
            Calculate(mathOperationType);
        }
        finally
        {
            AskToContinue();
        }
    }
    private void AskToContinue()
    {
        Console.WriteLine("Do want to continue ? y(yes) or n(no) : ");
        string continueResult = Console.ReadLine() ?? "n";
        Console.Clear();
        if (continueResult.ToLower() == "y" || continueResult.ToLower() == "yes")
        {
            TryToCalc();
        }
        else
        {
            Console.WriteLine("Finish.");
            Environment.Exit(0);
        }
    }
    private (bool result, MathOperationType operationType) ChooseOperation()
    {
        var enumNames = Enum.GetValues(typeof(MathOperationType));
        Console.WriteLine("Please Choose Your Operation :");
        foreach (MathOperationType item in enumNames)
        {
            if (item == MathOperationType.None)
                continue;
            Console.WriteLine((int)item + " : " + item.ToString());
        }
        Console.WriteLine("-------------------------");
        Console.WriteLine("Enter Operation Number : ");
        bool canGetNumber = int.TryParse(Console.ReadLine(), out int result);
        if (!canGetNumber || result > enumNames.Length - 1 || result <= 0)
        {
            Console.WriteLine("Invalid Operation Number!");
            return (false, 0);
        }
        return (true, (MathOperationType)result);

    }
    private (double firstNumber, double secondNumber) GetOperationValues()
    {
        Console.WriteLine("Please Enter First Number : ");
        double.TryParse(Console.ReadLine(), out double firstNum);
        Console.WriteLine("Please Enter Second Number : ");
        double.TryParse(Console.ReadLine(), out double secondNum);
        Console.WriteLine("-------------------------");
        return (firstNum, secondNum);
    }
    public static string FromJson(string jsonModel)
    {
        var model = JsonSerializer.Deserialize<ExceptionModel>(jsonModel);
        string writeException = string.Empty;
        if (model != null)
        {
            writeException =
            Environment.NewLine + "Where : " + model.Where +
            Environment.NewLine + "Code : " + model.Code +
            Environment.NewLine + "Message : " + model.Message +
            Environment.NewLine;
        }
        return writeException;
    }
}
