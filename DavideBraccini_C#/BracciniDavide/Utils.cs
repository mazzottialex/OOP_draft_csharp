using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracciniDavide
{
    /// <summary>
    /// Class that creates a series of players.
    /// </summary>
    public class Utils
    {
        private readonly List<Player> _liGiocatori;

        /// <summary>
        /// the constructor of Utils.
        /// </summary>
        public Utils()
        {
            _liGiocatori = new List<Player>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>A list of 30 Serie A players</returns>
        public List<Player> GetLiGiocatori()
        {
            _liGiocatori.Add(new Player(0, "Martinez", 90));
            _liGiocatori.Add(new Player(1, "Barella", 90));
            _liGiocatori.Add(new Player(2, "Brozovic", 90));
            _liGiocatori.Add(new Player(3, "Dimarco", 87));
            _liGiocatori.Add(new Player(4, "De vrij", 85));
            _liGiocatori.Add(new Player(5, "Asslani", 80));
            _liGiocatori.Add(new Player(6, "Raspadori", 88));
            _liGiocatori.Add(new Player(7, "Bastoni", 89));
            _liGiocatori.Add(new Player(8, "Dumfries", 85));
            _liGiocatori.Add(new Player(9, "Lukaku", 88));
            _liGiocatori.Add(new Player(10, "Acerbi", 86));
            _liGiocatori.Add(new Player(11, "Leao", 90));
            _liGiocatori.Add(new Player(12, "Giroud", 85));
            _liGiocatori.Add(new Player(13, "Ibra", 80));
            _liGiocatori.Add(new Player(14, "Krunic", 77));
            _liGiocatori.Add(new Player(15, "Tonali", 88));
            _liGiocatori.Add(new Player(16, "Messias", 81));
            _liGiocatori.Add(new Player(17, "Theo", 83));
            _liGiocatori.Add(new Player(18, "Tomori", 84));
            _liGiocatori.Add(new Player(19, "Kalulu", 85));
            _liGiocatori.Add(new Player(20, "Calabria", 86));
            _liGiocatori.Add(new Player(21, "Milik", 88));
            _liGiocatori.Add(new Player(22, "Chiesa", 88));
            _liGiocatori.Add(new Player(23, "Di maria", 88));
            _liGiocatori.Add(new Player(24, "Bremer", 88));
            _liGiocatori.Add(new Player(25, "Locatelli", 88));
            _liGiocatori.Add(new Player(26, "Rabiot", 88));
            _liGiocatori.Add(new Player(27, "Gatti", 88));
            _liGiocatori.Add(new Player(28, "Cuadrado", 88));
            _liGiocatori.Add(new Player(29, "Oshimen", 88));
            return _liGiocatori;
        }
    }
}
