namespace Packets;

public class PacketListener<T> where T : Packet
{
    public Dictionary<int, T> Packets;
    public PacketListener()
    {
        var packetType = typeof(T);
        Packets = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => packetType.IsAssignableFrom(p) && !p.IsInterface)
            .Select(type => (T)Activator.CreateInstance(type))
            .ToDictionary(packet => packet.GetId(), packet => packet);
    }
}