using TextDecoratorDemo.Abstractions;

namespace TextDecoratorDemo.Decorators;
internal class SeparateLettersDecorator(ITextDecorator textDecorator) : ITextDecorator {
    public int OperationsCount => textDecorator.OperationsCount + 1;

    public string Name => textDecorator.Name + "\n" + nameof(SeparateLettersDecorator);

    public string Decorate() {
        string newText = "( ";
        foreach(var item in textDecorator.Decorate()) {
            if(String.IsNullOrWhiteSpace(item.ToString())) {
                continue;
            }
            newText += ( item + " , " );
        }
        newText = newText.Remove(newText.Length - 2);
        return newText + ")";
    }

}
