using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    public class Npc
    {
        public string Name { get; }
        public string InteractionText { get; }


        public Npc(string name, string interactionText)
        {
            Name = name;
            InteractionText = interactionText;
        }

        public Npc(string v)
        {
        }

        public void Talk()
        {
            Console.WriteLine(InteractionText);
        }
    }
}
