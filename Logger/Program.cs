namespace Delegates;

internal class Program
{
    static void Main(string[] args)
    {
        LoggingMethods.ActivateLogToConsole();
        LoggingMethods.ActivateLoggingToFile(@"C:\Users\Abdulrahman\Desktop\Sample.txt");

        Logger.LogMessage(Logger.Severity.Critical, "asdf", "hello");
        
        Console.ReadLine();


        Logger.LogMessage(Logger.Severity.Critical, "asdf", "hello");
    }
}