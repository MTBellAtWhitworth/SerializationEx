////////////////////////////////////////////////////
///A simple example designed by M.Bell to use Troelsen and Japikse, 2022
///to show off serialization in .NET. As ever, Dr. Bell
///loves RPGs.
///////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableEx
{
    [Serializable]
    public class Player
    {
        public int Location { get; set; } // Holds the location for a player
        public string Name { get; set; }  // Holds a player name
        public int HP { get; set; }       // Their hit points
        //Other attibutes can go here....think big

        public Player() : this("Joe Runner") {} //<= Must have a default constructor for this to work!

        public Player(string name) : this(name, 1) {}

        public Player(string name, int hits) : this(name, hits, 0) {}

        public Player(string name, int hits, int loc)
        {
            Location = loc;
            Name = name;
            HP = hits;
        }
    }
}
