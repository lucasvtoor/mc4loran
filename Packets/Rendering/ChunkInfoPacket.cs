using System.Net.Sockets;
using World;

namespace Packets.Rendering;

public class ChunkInfoPacket: OutboundUdpPacket
{
    public Location[] Locations { get; set; }
   

    public ChunkInfoPacket(UdpWriter writer) : base(writer)
    {
        
    }
    public override void Send()
    {
        UdpWriter.WriteInt(Locations.Length);
        foreach (var loc in Locations)
        {
            UdpWriter.WriteInt((int) loc.Block);
            UdpWriter.WriteVec3(loc.Position);
        }
        UdpWriter.Send();
        
    }

    public override int GetId()
    {
        return (int)Packets.ChunkInfo;
    }
}