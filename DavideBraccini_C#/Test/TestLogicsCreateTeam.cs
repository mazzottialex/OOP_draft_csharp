using BracciniDavide;

namespace Test
{
    [TestClass]
    public class TestLogicsCreateTeam
    {

        // create 11 players to use as a test
        private readonly Player p0 = new Player(0, "p0", 68);
        private readonly Player p1 = new Player(1, "p1", 91);
        private readonly Player p2 = new Player(2, "p2", 74);
        private readonly Player p3 = new Player(3, "p3", 66);
        private readonly Player p4 = new Player(4, "p4", 64);
        private readonly Player p5 = new Player(5, "p5", 90);
        private readonly Player p6 = new Player(6, "p6", 89);
        private readonly Player p7 = new Player(7, "p7", 82);
        private readonly Player p8 = new Player(8, "p8", 84);
        private readonly Player p9 = new Player(9, "p9", 85);
        private readonly Player p10 = new Player(10, "p10", 79);

        [TestMethod]
        public void TestGetRandom()
        {
            int numPlayers = 8;
            ILogicsCreateTeam lc = new LogicsCreateTeamImpl("MyTeam", new Utils().GetLiGiocatori());
            List<Player> players = lc.GetRandom(numPlayers);
            Assert.AreEqual(numPlayers, players.Count);
        }

        [TestMethod]
        public void TestGetModuli()
        {
            int numModuli = Enum.GetValues(typeof(Module)).Length;
            ILogicsCreateTeam lc = new LogicsCreateTeamImpl("MyTeam", new Utils().GetLiGiocatori());
            List<Module> listModule = lc.GetModuli();
            Assert.AreEqual(listModule.Count, numModuli);
        }

        [TestMethod]
        public void TestAddPlayerInTeam()
        {
            ILogicsCreateTeam lc = new LogicsCreateTeamImpl("MyTeam", new Utils().GetLiGiocatori());
            lc.AddPlayerInTeam(p0);
            lc.AddPlayerInTeam(p1);
            lc.AddPlayerInTeam(p2);
            Assert.IsFalse(lc.TeamComplete(), "the Team is not complete, it has only 3 players");
            lc.AddPlayerInTeam(p3);
            lc.AddPlayerInTeam(p4);
            lc.AddPlayerInTeam(p5);
            lc.AddPlayerInTeam(p6);
            lc.AddPlayerInTeam(p7);
            lc.AddPlayerInTeam(p8);
            lc.AddPlayerInTeam(p9);
            lc.AddPlayerInTeam(p10);
            Assert.IsTrue(lc.TeamComplete(), "the Team is complete now");
        }

        [TestMethod]
        public void TestAddEqualPlayers()
        {
            Player playerEqual = new Player(9, "p9", 85); //Player equals to p9
            ILogicsCreateTeam lc = new LogicsCreateTeamImpl("MyTeam", new Utils().GetLiGiocatori());
            lc.AddPlayerInTeam(p0);
            lc.AddPlayerInTeam(p1);
            lc.AddPlayerInTeam(p2);
            Assert.IsFalse(lc.TeamComplete(), "the Team is not complete, it has only 3 players");
            lc.AddPlayerInTeam(p3);
            lc.AddPlayerInTeam(p4);
            lc.AddPlayerInTeam(p5);
            lc.AddPlayerInTeam(p6);
            lc.AddPlayerInTeam(p7);
            lc.AddPlayerInTeam(p8);
            lc.AddPlayerInTeam(p9);          //equal
            lc.AddPlayerInTeam(playerEqual); //equal
            Assert.IsFalse(lc.TeamComplete(), "the Team is not complete, added 2 equal players");
        }
    }
}