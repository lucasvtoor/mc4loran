using System.Net.Sockets;
using Injectors;

namespace Packets.ConnectionManagement.Polling;

public class PollingRequestPacket : InboundTcpPacket
{
    public PollingRequestItems PollingRequestItems;

    public override void Receive(Injector injector, NetworkStream stream)
    {
        var pollingRequestItems = stream.ReadByte();
        PollingRequestItems = (PollingRequestItems)pollingRequestItems;

    }


    public override int GetId()
    {
        return (int)Packets.Polling;
    }
}