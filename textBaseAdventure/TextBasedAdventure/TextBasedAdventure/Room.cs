using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    public class Room
    {
        public string Name { get; set; }
        public static void LookThroughCloset()
        {
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine("You open the closet and find some clothes, but no water.");
            Thread.Sleep(2000);
            Console.WriteLine("You close the closet and think about your next move.");
        }
    }
}
