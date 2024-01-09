using System.Text;

namespace Util.Logging;

public class UltimateWriter(StreamWriter streamWriter, TextWriter consoleWriter) : TextWriter
{
    public override Encoding Encoding => Encoding.UTF8;

    public override void Write(string value)
    {
        streamWriter.Write(value);
        consoleWriter.Write(value);
    }

    public override void WriteLine(string value)
    {
        streamWriter.WriteLine(value);
        consoleWriter.WriteLine(value);
    }
}