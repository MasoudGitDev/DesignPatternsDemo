using AbstractFactory.Abstractions;
using AbstractFactory.Constants;
using System.Reflection;
using Shared.Extensions;

namespace AbstractFactory.Factories;

internal class ToolbarFactory {
    private const string _name = "Toolbar";
    public static IToolbar Create(ColorMode colorMode) {
        Type type = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x=>
                !x.IsAbstract &&
                !x.IsInterface &&
                x.IsAssignableTo(typeof(IToolbar)) &&
                x.Name.StartsWith(colorMode.ToString()) &&
                x.Name.EndsWith(_name)
             ).FirstOrDefault().IfNull($"The {colorMode}{_name} object can not found.");
        return ( Activator.CreateInstance(type) as IToolbar )
                .IfNull($"System can not create {type.Name} type.");
    }
}
