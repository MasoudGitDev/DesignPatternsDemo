// See https://aka.ms/new-console-template for more information
using TextDecoratorDemo.Abstractions;
using TextDecoratorDemo.Decorators;

Console.WriteLine("Hello, Decorator Pattern ! \n");

//var text = new UpperCaseDecorator ( new SeparateLettersDecorator( new RemoveDigitDecorator( new BaseText("hello Masoud 33"))));

ITextDecorator text = new BaseText("hello Masoud 99");
text = new RemoveDigitDecorator(text);
text = new SeparateLettersDecorator(text);
text = new UpperCaseDecorator(text);

Console.WriteLine("Result : " + text.Decorate() + "\n");
Console.WriteLine("Operations count :" + text.OperationsCount + "\n");
Console.WriteLine("Operation names : ");
Console.WriteLine(text.Name);
