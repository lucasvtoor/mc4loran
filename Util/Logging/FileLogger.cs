namespace Util.Logging;

public class FileLogger<T>(LogLevel level,StreamWriter writer) : Logger<T>(level,writer)
{
}