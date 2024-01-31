namespace Command.Abstraction;

public interface ICommand {
    void Execute();
    void Undo();
    decimal CurrentPrice { get; }
}

public interface IProductCommand :ICommand { }
