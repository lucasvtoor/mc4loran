namespace Packets.ConnectionManagement.Polling;

[Flags]
public enum PollingRequestItems
{
    PlayerCount,
    Motd,
    ServerName,
    PlayerList,
    AcceptableServerVersionRange,
}