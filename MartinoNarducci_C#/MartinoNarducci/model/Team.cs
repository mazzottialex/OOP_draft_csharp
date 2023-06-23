using System.Collections.Generic;

public class Team
{
    public string Name { get; }
    public List<Player> PlayerList { get; }
    public Player? GK { get; }

    public Team(string name, List<Player> playerList)
    {
        Name = name;
        PlayerList = new List<Player>(playerList);
        //PlayerList = playerList;
        foreach (Player p in playerList)
        {
            if (0 == p.Position)
            {
                GK = p;
            }
        }
    }
}
