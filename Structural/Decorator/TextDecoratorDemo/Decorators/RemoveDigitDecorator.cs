using TextDecoratorDemo.Abstractions;

namespace TextDecoratorDemo.Decorators;
internal class RemoveDigitDecorator(ITextDecorator textDecorator) : ITextDecorator {
    public int OperationsCount => textDecorator.OperationsCount + 1;

    public string Name => textDecorator.Name + "\n" + nameof(RemoveDigitDecorator);

    public string Decorate() {
        string newText = "";
        foreach(var item in textDecorator.Decorate()) {
            if(char.IsDigit(item)) {
                newText += ( "" );
            }
            else {
                newText += item;
            }
        }
        return newText;
    }
}
