using Injectors;
using Managers;
using Packets;
using System.Net;
using System.Net.Sockets;
using Util.Logging;

namespace Servers;

public class Server
{
    public TcpListener TcpListener;
    public UdpClient UdpClient;
    public TcpPacketListener TcpPacketListener;
    public UdpPacketListener UdpPacketListener;
    public Injector Injector;
    public Logger<Server> Logger;

    public Server(Injector injector)
    {
        Logger = new LoggerFactory((LogLevel)injector.Get<SettingsManager>().LogLevelSetting.Value,
            (LogLocation)injector.Get<SettingsManager>().LogLocationSetting.Value).GetLogger<Server>();
        UdpPacketListener = new();
        TcpPacketListener = new();
        TcpListener = new TcpListener(IPAddress.Parse((string)injector.Get<SettingsManager>().HostNameSetting.Value),
            injector.Get<SettingsManager>().PortSetting.Value);
        UdpClient = new UdpClient((string)injector.Get<SettingsManager>().HostNameSetting.Value,
            injector.Get<SettingsManager>().PortSetting.Value);
        Injector = new();
        var tcpThread = new Thread(ListenTcp);
        var udpThread = new Thread(ListenUdp);

        tcpThread.Start();
        udpThread.Start();
    }

    public void ShutDown()
    {
        TcpListener.Stop();
        UdpClient.Close();
    }

    private void ListenTcp()
    {
        TcpListener.Start();

        while (true)
        {
            TcpClient client = TcpListener.AcceptTcpClient();

            Thread clientThread = new Thread(() => HandleClient(client));
            clientThread.Start();
        }
    }

    private void HandleClient(TcpClient client)
    {
        while (client.Connected)
        {
            var stream = client.GetStream();
            var packetId = stream.ReadInt();
            TcpPacketListener.Packets[packetId].Receive(Injector, stream);
        }
    }

    private void ListenUdp()
    {
        while (true)
        {
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);
            byte[] data = UdpClient.Receive(ref endpoint);
            var reader = new UdpReader(data);
            var packetId = reader.ReadInt();
            UdpPacketListener.Packets[packetId].Receive(Injector, reader);
        }
    }
}