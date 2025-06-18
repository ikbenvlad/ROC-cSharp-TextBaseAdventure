using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    
    public class Character
    { 
        public string Name { get; set; }
        public Character(string name)
        {
            Name = name;
        } 
    }
}
