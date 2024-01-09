using Players;
using Util.Logging;

namespace Managers;

public class PlayerManager
{
    private Dictionary<string, Player> Players;
    public int PlayerCount;
    public string PlayerList;
    private Logger<PlayerManager> _logger;
    
    public PlayerManager(LoggerFactory loggerFactory)
    {
        _logger = loggerFactory.GetLogger<PlayerManager>();
        Players = new Dictionary<string, Player>();
        PlayerCount = 0;
        PlayerList = "";
    }

    bool AddPlayer(Player player)
    {
        if (Players.ContainsKey(player.UserName))
        {
            _logger.Info("Duplicate username detected, rejecting...");
            return false;
        }
        Players.Add(player.UserName, player);
        _logger.Info($"Player {player.UserName} added successfully");
        PlayerCount++;
        PlayerList += $"{player.UserName}, ";
        return true;
    }

    bool RemovePlayer(Player player)
    {
        if (Players.ContainsKey(player.UserName))
        {
            Players.Remove(player.UserName);
            _logger.Info($"Player {player.UserName} removed successfully");
            PlayerCount--;
            PlayerList = PlayerList.Replace($"{player.UserName}, ", "");
            return true;
        }
        _logger.Info($"Player {player.UserName} not found");
        return false;
    }
    
    

}