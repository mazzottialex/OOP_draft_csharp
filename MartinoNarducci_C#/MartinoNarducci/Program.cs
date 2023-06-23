// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Player p1a = new Player(0, "L. Skorupski", 50, 77);
        Player p2a = new Player(1, "G. Di Lorenzo", 76, 66);
        Player p3a = new Player(1, "Kim Min-Jae", 66, 67);
        Player p4a = new Player(1, "Carlos Augusto", 81, 63);
        Player p5a = new Player(1, "S. Posch", 77, 64);
        Player p6a = new Player(2, "S. Milinkovic-Savic", 86, 65);
        Player p7a = new Player(2, "A. Zambo Anguissa", 78, 66);
        Player p8a = new Player(2, "T. Koopmeiners", 85, 61);
        Player p9a = new Player(3, "M. Zaccagni", 86, 61);
        Player p10a = new Player(3, "R. Leao", 91, 52);
        Player p11a = new Player(3, "M. Lautaro", 92, 55);

        Player p1b = new Player(0, "W. Falcone", 50, 77);
        Player p2b = new Player(1, "Danilo", 74, 69);
        Player p3b = new Player(1, "R. Ibanez", 68, 66);
        Player p4b = new Player(1, "F. Tomori", 62, 65);
        Player p5b = new Player(1, "D. Udogie", 76, 63);
        Player p6b = new Player(2, "A. Rabiot", 83, 64);
        Player p7b = new Player(2, "M. Pessina", 78, 65);
        Player p8b = new Player(2, "Luis Alberto", 83, 63);
        Player p9b = new Player(3, "B. Dia", 88, 49);
        Player p10b = new Player(3, "K. Kvaratskhelia", 90, 60);
        Player p11b = new Player(3, "V. Osimhen", 93, 50);

        List<Player> team1Players = new List<Player>
        {
            p1a, p2a, p3a, p4a, p5a, p6a, p7a, p8a, p9a, p10a, p11a
        };

        Team team1 = new Team("Team 1", team1Players);

        List<Player> team2Players = new List<Player>
        {
            p1b, p2b, p3b, p4b, p5b, p6b, p7b, p8b, p9b, p10b, p11b
        };

        Team team2 = new Team("Team 2", team2Players);

        Shootout S = new Shootout(team1, team2);
        S.CreateAndShowGUI();

    }
}
