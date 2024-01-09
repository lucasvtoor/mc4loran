using System.Net.Sockets;

namespace Packets.ConnectionManagement.Polling;

public class PollingResponsePacket(
    PollingRequestItems items,
    int playerCount,
    string motd,
    string serverName,
    string playerList,
    string minVersion,
    string maxVersion,
    params NetworkStream[] streams) : OutboundTcpPacket(streams)
{
    public override void Send()
    {
        if (items.HasFlag(PollingRequestItems.Motd))
        {
            Streams.WriteString(motd);
        }

        if (items.HasFlag(PollingRequestItems.PlayerCount))
        {
            Streams.WriteInt(playerCount);
        }

        if (items.HasFlag(PollingRequestItems.ServerName))
        {
            Streams.WriteString(serverName);
        }

        if (items.HasFlag(PollingRequestItems.PlayerList))
        {
            Streams.WriteString(playerList);
        }

        if (items.HasFlag(PollingRequestItems.AcceptableServerVersionRange))
        {
            Streams.WriteString(minVersion);
            Streams.WriteString(maxVersion);
        }
    }

    public override int GetId()
    {
        return (int)Packets.Polling;
    }
}