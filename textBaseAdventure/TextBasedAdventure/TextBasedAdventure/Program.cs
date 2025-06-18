using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name...");
            string name = Console.ReadLine()?.ToLower();
            if (string.IsNullOrEmpty(name))
            {
                name = "child";
                return;
            }

            Console.WriteLine($"Welcome, {name}.");
            Thread.Sleep(1000);
            Console.WriteLine("Today was a long day, try to get some rest.");
            Thread.Sleep(1000);
            Console.WriteLine("You go to sleep and fade off to sleep.");
            Thread.Sleep(4000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(4000);
            Console.Clear();
            WakingUp.WokeUp();
        }
    }
}
