﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    class Program
    {
        static void Main()
        {
            Npc persoon = new Npc(" npcnaam", "Must've been the wind");
            persoon.Talk();
        }
    }
}
