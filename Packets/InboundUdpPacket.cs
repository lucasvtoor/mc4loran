using Injectors;
namespace Packets;

public abstract class InboundUdpPacket : UdpPacket
{
    public abstract void Receive(Injector injector, UdpReader udpReader);
}