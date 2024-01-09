using System.Numerics;
using System.Text;

namespace Packets;

public class UdpReader(byte[] data)
{
    public byte[] Data = data;
    private int iterator;


    public byte ReadByte()
    {
        byte value = Data[iterator];
        iterator++;
        return value;
    }

    public float ReadFloat()
    {
        float value = BitConverter.ToSingle(Data, iterator);
        iterator += sizeof(float);
        return value;
    }

    public Vector3 ReadVec3()
    {
        float x = ReadFloat();
        float y = ReadFloat();
        float z = ReadFloat();
        return new Vector3(x, y, z);
    }

    public int ReadInt()
    {
        var i = BitConverter.ToInt32(Data, iterator);
        iterator += sizeof(int);
        return i;
    }

    public string ReadString()
    {
        var length = ReadInt();
        var str = Encoding.UTF8.GetString(Data, iterator, length);
        iterator += length;
        return str;
    }
}