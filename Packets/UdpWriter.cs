using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Text;

namespace Packets;

public class UdpWriter(UdpClient client, params IPEndPoint[] endPoints)
{
    private UdpClient Client = client;
    private IPEndPoint[] EndPoints = endPoints;
    public List<byte> Data = new();

    public UdpWriter WriteFloat(float f)
    {
        Data.AddRange(BitConverter.GetBytes(f));
        return this;
    }

    public UdpWriter WriteInt(int i)
    {
        Data.AddRange(BitConverter.GetBytes(i));
        return this;
    }

    public UdpWriter WriteString(string s)
    {
        Data.AddRange(BitConverter.GetBytes(s.Length));
        Data.AddRange(Encoding.UTF8.GetBytes(s));
        return this;
    }

    public UdpWriter WriteVec3(Vector3 vector3)
    {
        Data.AddRange(BitConverter.GetBytes(vector3.X));
        Data.AddRange(BitConverter.GetBytes(vector3.Y));
        Data.AddRange(BitConverter.GetBytes(vector3.Z));
        return this;
    }

    public void Send()
    {
        var data = Data.ToArray();
        var length = data.Length;
        foreach (var endpoint in endPoints)
        {
            Client.Send(data, length, endpoint);
        }
    }
}