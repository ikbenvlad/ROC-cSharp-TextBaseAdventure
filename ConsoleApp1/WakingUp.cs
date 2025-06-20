using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WakingUp
    {
        public static void WokeUp()
        {
            Thread.Sleep(2500);
            Console.WriteLine("You wake up.");
            Thread.Sleep(2500);
            Console.WriteLine("It's 03:03 am.");
            Thread.Sleep(2500);
            Console.Clear();
            Thread.Sleep(3000);
            Console.WriteLine("You are thirsty.");
            Thread.Sleep(2500);
            Console.WriteLine("Get a glass of water.");
            Thread.Sleep(2500);
            Console.Clear();
            WokeUpChoice();
        }

        public static void WokeUpChoice()
        {
            Thread.Sleep(1000);
            Console.WriteLine("What would you like to do?");
            Thread.Sleep(2500);
            Console.WriteLine("1. Look through your room");
            Thread.Sleep(1000);
            Console.WriteLine("2. Walk towards the hallway");
            Thread.Sleep(1000);
            Console.WriteLine("3. Go back to sleep");
            string choice = Console.ReadLine()?.ToLower();
            switch (choice)
            {
                case "1":
                    WakingUpRoom();
                    break;
                case "2":
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.WriteLine("Walking");
                    Thread.Sleep(2500);
                    Console.WriteLine(".");
                    Thread.Sleep(2500);
                    Console.WriteLine(".");
                    Thread.Sleep(2500);
                    Console.WriteLine(".");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Rooms.HallwayFlashOff();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("You decide to go back to sleep, hoping to wake up refreshed in the morning.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Bad desicion, {Program.Name}!");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Thread.Sleep(3000);
                    Nightmare.NightmareStart();
                    break;
                case "g":
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (!Program.Inventory.Any())
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Your inventory is empty.");
                        Thread.Sleep(1000);
                        WokeUpChoice();
                    }
                    else
                    {
                        Program.Inventory.ForEach(item => Console.WriteLine($"{item.Name}: {item.Description}"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        WokeUpChoice();
                    }
                        break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    WokeUpChoice();
                    return;
            }
        }

        public static void WakingUpRoom()
        {
            Program.Inventory.Add(new Program.inv("Phone", "Your phone, used to light up the room."));
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("It's dark, but you manage to look through your room.");
            Thread.Sleep(2500);
            Console.WriteLine("Lucky you, you remember to use your phone light to look around. (press G to view)");
            Thread.Sleep(2500);
            Console.WriteLine("What would you like to do next?");
            Thread.Sleep(2500);
            Rooms.BedroomLocals();
        }
    }
}
