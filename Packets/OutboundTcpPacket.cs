using System.Net.Sockets;
using System.Runtime.Serialization;

namespace Packets;

public abstract class OutboundTcpPacket : TcpPacket
{
    public NetworkStream[] Streams { get; set; }

    public OutboundTcpPacket(params NetworkStream[] streams)
    {
        Streams = streams; 
        streams.WriteInt(GetId());
    }



    public abstract void Send();
}