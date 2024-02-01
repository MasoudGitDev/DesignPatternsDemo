namespace Shared.Services;
public class Logger {
    public static void Log(string message)  => Console.Write(message + "\n");
    public static void CreateTitle(string message) => Console.WriteLine($"====================== {message} =================\n");
}
