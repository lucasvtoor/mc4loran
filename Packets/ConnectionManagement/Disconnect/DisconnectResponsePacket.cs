namespace Packets.ConnectionManagement.Disconnect;

public class DisconnectResponsePacket(UdpWriter writer) : OutboundUdpPacket(writer)
{
    public string Reason;

    public override int GetId()
    {
        return (int)Packets.Disconnect;
    }

    public override void Send()
    {
        writer.WriteString(Reason);
    }
}