namespace Command.Logger;
internal class LogController {
    public static void Log(string message) {
        Console.WriteLine(message);
    }
    public static void CreateDash() {
        Console.WriteLine("---------------------");
    }
}
