namespace Packets;

public abstract class OutboundUdpPacket(UdpWriter writer) : UdpPacket
{
    public UdpWriter UdpWriter = writer;
    public abstract void Send();
}