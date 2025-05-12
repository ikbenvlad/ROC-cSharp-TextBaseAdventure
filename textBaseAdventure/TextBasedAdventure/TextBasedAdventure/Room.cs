using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    public class Room
    {
        public string Name { get; set; }
        public List<Room> RoomsAllowedToGoTo { get; set; }
        public Room(string name)
        {
            Name = name;
            RoomsAllowedToGoTo = new List<Room>();
        }
    }
}
