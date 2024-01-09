namespace Util.Logging;

public class LoggerFactory(LogLevel level, LogLocation location)
{
    public StreamWriter? FileWriter;

    public Logger<T> GetLogger<T>()
    {
        return location switch
        {
            LogLocation.All => new UltimateLogger<T>( level, new UltimateWriter(GetFileWriter(), Console.Out)),
            LogLocation.Console => new ConsoleLogger<T>(level),
            LogLocation.File => new FileLogger<T>(level, GetFileWriter()),
            _ => throw new NotImplementedException()
        };
    }

    public StreamWriter GetFileWriter()
    {
        return FileWriter ??= new StreamWriter($"{DateTime.Now}.txt");
    }
}