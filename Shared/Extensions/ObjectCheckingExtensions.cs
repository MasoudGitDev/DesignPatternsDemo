using Shared.Exceptions;

namespace Shared.Extensions;
public static class ObjectCheckingExtensions {

    public static T ThrowIfNull<T>(this T? source , string message) {
        if(source == null)
            throw new CustomException("NullObject" , message);
        return source;
    }

    public static TObject ThrowIfNull<TException, TObject>(this TObject? source , string message)
        where TException : CustomException {
        if(source == null)
            throw (TException) Activator.CreateInstance(typeof(TException) , "NullObject" , message)!;
        return source;
    }


}
