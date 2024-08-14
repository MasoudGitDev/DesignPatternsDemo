using ProductCommandDemo.Abstractions;

namespace ProductCommandDemo.Invoker;
internal class ProductInvoker :IProductInvoker{
    private readonly Stack<IProductCommand> _commands = [];
    private IProductCommand? _command;
    public void SetCommand(IProductCommand command) { 
        _command = command;
    }

    public void Invoke() {
        if(_command is null) return;
        _commands.Push(_command);
        _command.Execute();
    }

    public void Undo() {
        if(_commands.Count <= 0) return;
        _commands.Pop();
        _command.Undo();
    }

    

}
