using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BracciniDavide
{
    /// <summary>
    /// The implamentation of the interface ILogicsCreateTeam.
    /// </summary>
    public class LogicsCreateTeamImpl : ILogicsCreateTeam
    {
        private static readonly int NumPlayerInTeam = 11;
        private static readonly int NumSubstitution = 7;
        private readonly List<Player> _liTitolari;
        private readonly List<Player> _liRiserve;
        private readonly string _teamName;
        private Module _module;
        private readonly List<Player> _liGiocatori;
        private readonly Random random = new Random();

        /// <summary>
        /// The constructor of LogicsCreateTeamImpl.
        /// </summary>
        /// <param name="teamName">The name of the team</param>
        /// <param name="liGiocatori">A list with some players from Serie A</param>
        public LogicsCreateTeamImpl(string teamName, List<Player> liGiocatori)
        {
            _liTitolari = new List<Player>();
            _teamName = teamName;
            _module = Module.M433;
            _liGiocatori = liGiocatori;
            _liRiserve = GetRandom(NumSubstitution);
        }

        /// <inheritdoc />
        public void AddPlayerInTeam(Player player) 
        {
            if (!_liTitolari.Contains(player))
            {
                _liTitolari.Add(player);
            }
        }

        /// <inheritdoc />
        public void ClearTeam()
        {
            _liTitolari.Clear();
        }

        /// <inheritdoc />
        public Module GetModule() => _module;

        /// <inheritdoc />
        public List<Module> GetModuli()
        {
            List<Module> modules = new List<Module>();
            foreach (Module m in Enum.GetValues(typeof(Module)))
            {
                modules.Add(m);
            }
            return modules;
        }

        /// <inheritdoc />
        public int GetNumAtt()
        {
            if (_module == Module.M433 || _module == Module.M343)
            {
                return 3;
            } 
            else
            {
                return 2;
            }
        }

        /// <inheritdoc />
        public int GetNumCen()
        {
            if (_module == Module.M442 || _module == Module.M343)
            {
                return 4;
            } 
            else if (_module == Module.M532 || _module == Module.M433)
            {
                return 3;
            }
            else
            {
                return 5;
            }
        }

        /// <inheritdoc />
        public int GetNumDif()
        {
            if (_module == Module.M433 || _module == Module.M442)
            {
                return 4;
            }
            else if (_module == Module.M343 || _module == Module.M352)
            {
                return 3;
            }
            else
            {
                return 5;
            }
        }

        /// <inheritdoc />
        public List<Player> GetRandom(int n)
        {
            HashSet<Player> set = new HashSet<Player>();
            List<Player> listRandom = new List<Player>();
            while (set.Count() != n)
            {
                int r = random.Next(0, _liGiocatori.Count);
                Player p = _liGiocatori[r];
                set.Add(p);
            }
            foreach (Player p in set)
            {
                listRandom.Add(p);
            }
            return listRandom;
        }

        /// <inheritdoc />
        public ITeam GetSquadra() => new TeamUser(0, _teamName, _module, _liTitolari, _liRiserve);

        /// <inheritdoc />
        public void SetModule(Module module) => _module = module;

        /// <inheritdoc />
        public bool TeamComplete() => _liTitolari.Count == NumPlayerInTeam;
    }
}
