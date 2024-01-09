namespace Packets.ConnectionManagement.Login;

public class LoginResponsePacket:OutboundTcpPacket
{
    public bool Success;
    public override void Send()
    {
        Streams.WriteBool(Success);
    }

    public override int GetId()
    {
        return (int)Packets.Login;
    }
}