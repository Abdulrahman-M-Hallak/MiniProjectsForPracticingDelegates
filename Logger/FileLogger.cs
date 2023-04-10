namespace Delegates;

internal class FileLogger
{
    private readonly string _filepath;

    public FileLogger(string path)
    {
        _filepath= path;
        Logger.WriteMessage += LogMessage;

        if(!File.Exists(_filepath))
            File.Create(path).Close();
    }

    public void DetachLog() => Logger.WriteMessage -= LogMessage;
    private void LogMessage(string msg)
    {
        try
        {
            using var log = File.AppendText(_filepath);
            log.WriteLine(msg);
            log.Flush();
        }
        catch (FileNotFoundException)
        {
            File.Create(_filepath).Close();
            using var log = File.AppendText(_filepath);
            log.WriteLine(msg);
            log.Flush();
        }
        catch(Exception)
        {

        }
    }
}
