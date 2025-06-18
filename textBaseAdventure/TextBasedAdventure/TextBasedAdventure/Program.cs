using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name...");
            string playerName = Console.ReadLine();

            if (string.IsNullOrEmpty(playerName))
            {
                playerName = "Son";
            }

            Console.WriteLine($"Welcome, {playerName}.");
            Thread.Sleep(1500);
            Console.WriteLine("You've worked hard today, and you're tired.");
            Thread.Sleep(1500);
            Console.WriteLine("You decide to head to bed early.");
            Thread.Sleep(1500);
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1500);
            Console.Clear();
            Thread.Sleep(500);
            WakingUp.WokeUp();
        }

        public static List<Room> BedroomLocals = new List<Room>()
        {
            new Room { Name = "bed" },
            new Room { Name = "closet" },
            new Room { Name = "desk" },
            new Room { Name = "hallway" }
        };
    }
}
