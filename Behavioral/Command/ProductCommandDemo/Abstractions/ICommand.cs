namespace ProductCommandDemo.Abstractions;
internal interface IProductCommand {
    void Execute();
    void Undo();
}
