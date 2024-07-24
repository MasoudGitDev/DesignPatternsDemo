using TextDecoratorDemo.Abstractions;

namespace TextDecoratorDemo.Decorators;
internal class UpperCaseDecorator(ITextDecorator textDecorator) : ITextDecorator {
    public int OperationsCount => textDecorator.OperationsCount + 1;

    public string Name => textDecorator.Name + "\n" + nameof(UpperCaseDecorator);

    public string Decorate() {
        return textDecorator.Decorate().ToUpper();
    }
}
