using System.Net.Sockets;
using Injectors;

namespace Packets.ConnectionManagement.Login;

public class LoginRequestPacket: InboundTcpPacket
{
    public string Token;
    public override void Receive(Injector injector, NetworkStream stream)
    {
        Token = stream.ReadString();
    }

    public override int GetId()
    {
        return (int)Packets.Login;
    }
}