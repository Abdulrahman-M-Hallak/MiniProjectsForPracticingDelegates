using Logger;

namespace Delegates;

internal class Program
{
    static void Main(string[] args)
    {
        LoggingMethods.ActivateLogToConsole();
        LoggingMethods.ActivateLoggingToFile(@"<filepath>");

        Logger.LogMessage(Logger.Severity.Critical, "asdf", "hello");
        
        Console.ReadLine();


        Logger.LogMessage(Logger.Severity.Critical, "asdf", "hello");
    }
}