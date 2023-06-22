using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracciniDavide
{
    /// <summary>
    /// The class that represents the user team.
    /// </summary>
    public class TeamUser : ITeam 
    {
        private readonly int _id;
        private readonly string _teamName;
        private readonly Module _module;
        private List<Player> _starting;
        private List<Player> _substitution;

        /// <summary>
        /// The constructor of TeamUser.
        /// </summary>
        /// <param name="id">The id of the team</param>
        /// <param name="teamName">The name of the team</param>
        /// <param name="module">The module of the team</param>
        /// <param name="liTitolari">The list of starting players</param>
        /// <param name="liRiserve">The list of substitution</param>
        public TeamUser(int id, string teamName, Module module, List<Player> liTitolari, List<Player> liRiserve)
        {
            _id = id;
            _teamName = teamName;
            _module = module;
            _starting = liTitolari;
            _substitution = liRiserve;
        }

        /// <inheritdoc />
        public Module GetModule() => _module;

        /// <inheritdoc />
        public string GetTeamName() => _teamName;

        /// <inheritdoc />
        public List<Player> GetStarting() => _starting;

        /// <inheritdoc />
        public List<Player> GetSubstitution() => _substitution;

        /// <inheritdoc />
        public void SetStarting(List<Player> starting) => _starting = starting;

        /// <inheritdoc />
        public void SetSubstitution(List<Player> substitution) => _substitution = substitution;

        /// <inheritdoc />
        public int GetId() => _id;

        /// <summary>
        /// 
        /// </summary>
        /// <returns>ToString of TeamUser.</returns>
        public override string ToString()
        {
            string startingPlayer = "\n";
            foreach (var Player in _starting)
            {
                startingPlayer += $"Player: {Player.GetName()}, rating: {Player.GetRating()}\n";
            }
            string substitutionPlayer = "\n";
            foreach (var Player in _substitution)
            {
                substitutionPlayer += $"Player: {Player.GetName()}, rating: {Player.GetRating()}\n";
            }
            return $"id: {_id}, team name: {_teamName}, module: {_module}, " + 
                $"starting: {startingPlayer} substitution: {substitutionPlayer}";
        }
        
    }
}
