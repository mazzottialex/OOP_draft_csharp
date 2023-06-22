using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracciniDavide
{
    /// <summary>
    /// This class implements a player.
    /// </summary>
    public class Player
    {
        private readonly int _id;
        private readonly string _name;
        private readonly int _rating;

        /// <summary>
        /// The costuctor of Player.
        /// </summary>
        /// <param name="id">The player's id</param>
        /// <param name="name">The player's name</param>
        /// <param name="rating">The player's rating</param>
        public Player(int id,string name, int rating) 
        {
            _id = id;
            _name = name;
            _rating = rating;
        }

        /// <summary>
        /// Equals.
        /// </summary>
        /// <param name="obj">Another player</param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is Player player &&
                   _id == player._id &&
                   _name == player._name &&
                   _rating == player._rating;
        }

        /// <summary>
        /// HashCode.
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(_id, _name, _rating);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The player's id</returns>
        public int GetId() => _id;

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The player's name</returns>
        public string GetName() => _name;

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The player's rating</returns>
        public int GetRating() => _rating;

    }
}
