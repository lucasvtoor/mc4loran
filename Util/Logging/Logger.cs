namespace Util.Logging;

public abstract class Logger<T>(LogLevel level, TextWriter writer)
{
    public void Error(string msg)
    {
        if (level < LogLevel.Error) return;
        writer.Write("[ ERROR ]: ");
        Print(msg);

    }

    public void Info(string msg)
    {
        if (level < LogLevel.Info) return;
        writer.Write("[ INFO ]: ");
        Print(msg);
    }

    public void Debug(string msg)
    {
        if (level < LogLevel.Debug) return;
        writer.Write("[ DEBUG ]: ");
        Print(msg);
    }

    public void Critical(string msg)
    {
        if (level < LogLevel.Critical) return;
        writer.Write("[ CRITICAL ]: ");
        Print(msg);
    }

    public void Warning(string msg)
    {
        if (level < LogLevel.Warning) return;
        writer.Write("[ WARNING ]: ");
        Print(msg);
    }

    public void Print(string msg)
    {
        writer.WriteLine($"[{DateTime.Now}] ({typeof(T)}) {msg}");
    }
}