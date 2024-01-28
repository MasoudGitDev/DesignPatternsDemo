using Strategy.Exceptions;
using Strategy.Models;
using System.Runtime.CompilerServices;

namespace Strategy.Extensions;
public static class GenericExtensions {
    public static T CheckNullability<T>(this T? source , ExceptionModel model) {
        if (source == null) throw new CustomException(model);
        return source;
    }
    public static T CheckNullability<T>(this T? source , string message) {
        if(source == null) throw new CustomException(message);
        return source;
    }
    public static void IfIsFalse(this bool condition , Action action) { if(condition is false) action.Invoke(); }  
    public static void WhenDone(this Action action) { action.Invoke(); }
}
