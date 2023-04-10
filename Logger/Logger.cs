namespace Logger;

public static class Logger
{
    public enum Severity
    {
        Verbose,
        Trace,
        Information,
        Warning,
        Error,
        Critical
    }

    public static Action<string>? WriteMessage;
    public static Severity LogLevel { get; set; } = Severity.Warning;
    public static void LogMessage(Severity s, string component, string msg)
    {
        if (s < LogLevel)
            return;

        var outputMessage = $"{DateTime.Now}\t{s}\t{component}\t{msg}";
        WriteMessage?.Invoke(outputMessage);
    }
}