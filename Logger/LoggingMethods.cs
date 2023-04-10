namespace Delegates;

public static class LoggingMethods
{
    private static FileLogger? _fileLogger;
    public static void ActivateLogToConsole() => Logger.WriteMessage += Console.Error.WriteLine;

    public static void ActivateLoggingToFile(string path)
    {
        var fileLogger = new FileLogger(path);
        _fileLogger = fileLogger;
    }
    public static void DetachLoggingToFile() => _fileLogger?.DetachLog();
}