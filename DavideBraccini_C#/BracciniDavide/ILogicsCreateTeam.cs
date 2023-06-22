using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracciniDavide
{
    /// <summary>
    /// Interface that models team creation.
    /// </summary>
    public interface ILogicsCreateTeam
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The TeamUser</returns>
        ITeam GetSquadra();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The number of defenders</returns>
        int GetNumDif();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The number of midfielders</returns>
        int GetNumCen();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The number of strikers</returns>
        int GetNumAtt();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player">The player to add to the team</param>
        void AddPlayerInTeam(Player player);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>True if the team is complete, false otherwise</returns>
        bool TeamComplete();

        /// <summary>
        /// Eliminate all players from the team.
        /// </summary>
        void ClearTeam();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">The number of players</param>
        /// <returns>A list of n players</returns>
        List<Player> GetRandom(int n);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>A list with all modules</returns>
        List<Module> GetModuli();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="module">The module you want to set</param>
        void SetModule(Module module);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The TeamUser module</returns>
        Module GetModule();
    }
}
