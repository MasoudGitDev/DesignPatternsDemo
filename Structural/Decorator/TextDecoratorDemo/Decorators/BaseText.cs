using TextDecoratorDemo.Abstractions;

namespace TextDecoratorDemo.Decorators;
internal class BaseText(string text) : ITextDecorator {
    public int OperationsCount => 1;

    public string Name => nameof(BaseText);

    public string Decorate() {
        return text;
    }
}
