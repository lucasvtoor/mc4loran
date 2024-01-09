using Injectors;

namespace Packets.ConnectionManagement.Disconnect;

public class DisconnectRequestPacket : InboundUdpPacket
{
    public override int GetId()
    {
        return (int)Packets.Disconnect;
    }

    public override void Receive(Injector injector, UdpReader udpReader)
    {
        throw new NotImplementedException();
    }
}