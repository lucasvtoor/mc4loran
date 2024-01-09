using System.Net.Sockets;
using Injectors;

namespace Packets;

public abstract class InboundTcpPacket : TcpPacket
{
    public abstract void Receive(Injector injector,NetworkStream stream);
}