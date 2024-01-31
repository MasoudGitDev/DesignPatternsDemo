using Command.Abstraction;
using Command.Logger;
using Command.ValueObjects;

namespace Command.Invokers;
public record class ProductInvoker : IInvoker {

    public Stack<IProductCommand> _commands { get; } = new();

    private IProductCommand? _productCommand;
    public void SetCommand(IProductCommand command) {
        _productCommand = command;
    }

    public void Invoke() {
        if(_productCommand is null) {
            LogController.Log("Please choose a command.");
            return;
        }

        try {
            _commands.Push(_productCommand);
            _productCommand.Execute();
           
            Console.WriteLine("Stack count : " + _commands.Count());
        }
        catch(Exception ex) {
            LogController.Log(ex.Message.ToString());
            Undo();
            
        }
        finally {
            LogController.CreateDash();
        }

    }
    public void Undo() {
        LogController.Log("\nUndo start.\n");
        Console.WriteLine("Stack count : " + _commands.Count());        
        _commands.Pop();
        LogController.Log($"Undo : Back to Last price :{_commands.Peek().CurrentPrice}\n");
        LogController.Log("Undo end.");
    }
}
