namespace TextDecoratorDemo.Abstractions;
internal interface ITextDecorator {
    string Decorate();
    int OperationsCount { get; }
    string Name { get; }
}
