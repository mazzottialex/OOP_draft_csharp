using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracciniDavide
{
    /// <summary>
    /// Interface that models the team.
    /// </summary>
    public interface ITeam
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The list of starting players</returns>
        List<Player> GetStarting();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The list of substitution</returns>
        List<Player> GetSubstitution();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The name of the team</returns>
        String GetTeamName();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The module of the team</returns>
        Module GetModule();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="starting">The list of starting players</param>
        void SetStarting(List<Player> starting);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="substitution">The list of substitution</param>
        void SetSubstitution(List<Player> substitution);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The id of the team</returns>
        int GetId();
    }
}
