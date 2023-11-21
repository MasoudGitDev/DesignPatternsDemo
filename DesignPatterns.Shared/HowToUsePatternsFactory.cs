using DesignPatterns.Shared.Abstractions;
using DesignPatterns.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared;
public class HowToUsePatternsFactory {
    private static readonly string _libNamespace = "DesignPatterns.Shared";
    public static void MakeExample(Consts.DesignPatterns pattern) {
        try {
            string assemblyName = $"DesignPatterns.Shared.{pattern}Pattern";
            Assembly assembly = Assembly.Load(assemblyName) !;
            Type? type = assembly.GetType(assemblyName + ".HowToUse");
            if (type != null ) {
                var patternExample = (IHowToUse?) Activator.CreateInstance(type);
                patternExample?.MakeExample();
            }
        }
        catch(Exception ex) { LogService.Log(ex.Message); }
    }
}