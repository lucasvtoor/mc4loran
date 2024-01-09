using System.Net;

namespace Players;

public class Player(IPEndPoint ip)
{
    public IPEndPoint Ip = ip;
    public string UserName;
    public string Nickname;
}