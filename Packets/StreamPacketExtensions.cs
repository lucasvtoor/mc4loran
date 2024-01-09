using System.Net.Sockets;
using System.Numerics;
using System.Text;

namespace Packets;

public static class StreamPacketExtensions
{
    #region Write TCP

    public static void WriteString(this NetworkStream stream, string s)
    {
        var motdBytes = Encoding.UTF8.GetBytes(s);
        var lengthBytes = BitConverter.GetBytes(motdBytes.Length);
        stream.Write(lengthBytes, 0, lengthBytes.Length);
        stream.Write(motdBytes, 0, motdBytes.Length);
        stream.Flush();
    }


    public static void WriteString(this NetworkStream[] streams, string s)
    {
        var sBytes = Encoding.UTF8.GetBytes(s);
        var lengthBytes = BitConverter.GetBytes(sBytes.Length);
        foreach (var stream in streams)
        {
            stream.Write(lengthBytes, 0, lengthBytes.Length);
            stream.Write(sBytes, 0, sBytes.Length);
            stream.Flush();
        }
    }

    public static void WriteBool(this NetworkStream[] streams, bool b)
    {
        var bBytes = BitConverter.GetBytes(b);
        var lengthBytes = BitConverter.GetBytes(bBytes.Length);

        foreach (var stream in streams)
        {
            stream.Write(lengthBytes, 0, lengthBytes.Length);
            stream.Write(bBytes, 0, bBytes.Length);

            stream.Flush();
        }
    }

    public static void WriteVec3(this NetworkStream[] streams, Vector3 vector3)
    {
        WriteFloat(streams, vector3.X);
        WriteFloat(streams, vector3.Y);
        WriteFloat(streams, vector3.Z);
    }

    public static void WriteFloat(this NetworkStream[] streams, float f)
    {
        var iBytes = BitConverter.GetBytes(f);
        var lengthBytes = BitConverter.GetBytes(iBytes.Length);
        foreach (var networkStream in streams)
        {
            networkStream.Write(lengthBytes, 0, lengthBytes.Length);
            networkStream.Write(iBytes, 0, iBytes.Length);
            networkStream.Flush();
        }
    }

    public static void WriteInt(this NetworkStream[] streams, int i)
    {
        var iBytes = BitConverter.GetBytes(i);
        var lengthBytes = BitConverter.GetBytes(iBytes.Length);

        foreach (var networkStream in streams)
        {
            networkStream.Write(lengthBytes, 0, lengthBytes.Length);
            networkStream.Write(iBytes, 0, iBytes.Length);
            networkStream.Flush();
        }
    }

    #endregion

    #region Read TCP

    public static string ReadString(this NetworkStream stream)
    {
        var lengthBytes = new byte[sizeof(int)];
        stream.Read(lengthBytes, 0, lengthBytes.Length);
        var length = BitConverter.ToInt32(lengthBytes, 0);
        var messageBytes = new byte[length];
        stream.Read(messageBytes, 0, messageBytes.Length);
        return Encoding.UTF8.GetString(messageBytes);
    }

    public static int ReadInt(this NetworkStream stream)
    {
        var lengthBytes = new byte[sizeof(int)];
        stream.Read(lengthBytes, 0, lengthBytes.Length);
        var length = BitConverter.ToInt32(lengthBytes, 0);
        var messageBytes = new byte[length];
        stream.Read(messageBytes, 0, messageBytes.Length);
        return BitConverter.ToInt32(messageBytes);
    }

    #endregion
}

#region Write UDP

#endregion

#region Read UDP

#endregion