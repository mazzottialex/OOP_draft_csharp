using System;
using System.Collections.Generic;

public class LogicsShootoutImpl : ILogicsShootout
{
    private readonly Team T1;
    private readonly Team T2;
    private List<Player> PlayersT1;
    private List<Player> PlayersT2;
    private int GoalsT1;
    private int GoalsT2;
    private int ShootsT1;
    private int ShootsT2;
    private bool GoAhead;
    private readonly Dictionary<int, Pair<Player, string>> DictionaryT1;
    private readonly Dictionary<int, Pair<Player, string>> DictionaryT2;
    private readonly List<Dictionary<int, Pair<Player, string>>> List;
    private const int TotShoots = 10;
    private const double MinimumModifierRating = 0.8;
    private const double AddModifierRating = 0.4;
    private const double ConversionRateShootout = 0.95;
    private readonly Random R = new Random();

    public LogicsShootoutImpl(Team T1, Team T2)
    {
        this.T1 = T1;
        this.T2 = T2;
        PlayersT1 = new List<Player>(T1.PlayerList);
        PlayersT2 = new List<Player>(T2.PlayerList);
        GoalsT1 = 0;
        GoalsT2 = 0;
        ShootsT1 = 0;
        ShootsT2 = 0;
        GoAhead = true;
        List = new List<Dictionary<int, Pair<Player, string>>>();
        DictionaryT1 = new Dictionary<int, Pair<Player, string>>();
        DictionaryT2 = new Dictionary<int, Pair<Player, string>>();
    }

    public List<Dictionary<int, Pair<Player, string>>> Compute()
    {
        while (GoAhead)
        {
            if ((ShootsT1 + ShootsT2 >= TotShoots && ShootsT1 == ShootsT2 && GoalsT1 != GoalsT2)
                || (ShootsT1 + ShootsT2 < TotShoots && ((TotShoots / 2 - ShootsT1 + GoalsT1 < GoalsT2)
                || (TotShoots / 2 - ShootsT2 + GoalsT2 < GoalsT1))))
            {
                GoAhead = false;
            }
            else
            {
                if ((ShootsT1 + ShootsT2) % 2 == 0)
                {
                    if (PlayersT1.Count == 0)
                    {
                        PlayersT1 = new List<Player>(T1.PlayerList);
                    }
                    Player P = PlayersT1[PlayersT1.Count - 1];
                    PlayersT1.Remove(P);
                    string Res = Penalty(P, T2);
                    DictionaryT1.Add(ShootsT1, new Pair<Player, string>(P, Res));
                    if (Res == "Gol")
                    {
                        GoalsT1++;
                    }
                    ShootsT1++;
                }
                else
                {
                    if (PlayersT2.Count == 0)
                    {
                        PlayersT2 = new List<Player>(T2.PlayerList);
                    }
                    Player P = PlayersT2[PlayersT2.Count - 1];
                    PlayersT2.Remove(P);
                    string Res = Penalty(P, T1);
                    DictionaryT2.Add(ShootsT2, new Pair<Player, string>(P, Res));
                    if (Res == "Gol")
                    {
                        GoalsT2++;
                    }
                    ShootsT2++;
                }
            }
        }
        // PlayersT1 = T1.PlayerList;
        // PlayersT2 = T2.PlayerList;
        List.Add(DictionaryT1);
        List.Add(DictionaryT2);
        return List;
    }

    private string Penalty(Player Shooter, Team OppositeTeam)
    {
        double GkRating = 70;
        double ShooterRating = Shooter.OffensiveRating * (MinimumModifierRating + R.NextDouble() * AddModifierRating);
        if (OppositeTeam.GK != null)
        {
            GkRating = OppositeTeam.GK.DefensiveRating * (MinimumModifierRating + R.NextDouble() * AddModifierRating);
        }
        double ModGkRating = GkRating * ConversionRateShootout;
        if (ShooterRating > ModGkRating)
        {
            return "Gol";
        }
        else
        {
            return "Sbagliato";
        }
    }
}
