using AbstractFactory.Abstractions;
using AbstractFactory.Constants;
using System.Reflection;
using Shared.Extensions;

namespace AbstractFactory.Factories;

internal class DialogFactory {
    private const string _name = "Dialog";
    public static IDialog Create(ColorMode colorMode) {
        Type type = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x=>
                !x.IsAbstract &&
                !x.IsInterface &&
                x.IsAssignableTo(typeof(IDialog)) &&
                x.Name.StartsWith(colorMode.ToString()) &&
                x.Name.EndsWith(_name) 
             ).FirstOrDefault().IfNull($"The {colorMode}{_name} object can not found.");
        return ( Activator.CreateInstance(type) as IDialog )
                .IfNull($"System can not create {type.Name} type.");
    }
}

