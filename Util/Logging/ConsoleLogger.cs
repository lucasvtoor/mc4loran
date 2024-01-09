namespace Util.Logging;

public class ConsoleLogger<T>(LogLevel level) : Logger<T>(level,Console.Out)
{
    public void Error(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Error(msg);
        Console.ForegroundColor = ConsoleColor.White;

    }

    public void Info(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        base.Error(msg);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void Debug(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.Error(msg);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void Critical(string msg)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        base.Error(msg);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void Warning(string msg)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        base.Error(msg);
        Console.ForegroundColor = ConsoleColor.White;
    }
    
}