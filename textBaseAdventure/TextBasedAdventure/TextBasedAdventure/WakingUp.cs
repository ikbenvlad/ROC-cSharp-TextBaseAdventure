using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    class WakingUp
    {
        public static void WokeUp()
        {
            Console.WriteLine("You wake up. It's 03:03.");
            Thread.Sleep(2000);
            Console.WriteLine("You are thirsty.");
            Thread.Sleep(3000);
            Console.Clear();
            Thread.Sleep(200);
            Console.WriteLine("What would you like to do?");
            Thread.Sleep(1000);
            Console.WriteLine("1. Look though your room");
            Thread.Sleep(500);
            Console.WriteLine("2. Go towards the hall");
            Thread.Sleep(500);
            Console.WriteLine("3. Go back to sleep");
            string choices = Console.ReadLine()?.ToLower();
            switch(choices)
            {
                case "1":
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("You look around your room.");
                    Thread.Sleep(500);
                    Console.WriteLine("It's dark and you're a little sleep drunk, but trying your hardest you picked up your phone.");
                    Thread.Sleep(1000);
                    Console.WriteLine("You turn on the flashlight and look around your room.");
                    Thread.Sleep(1000);
                    Console.WriteLine("You see your bed, a closet, a desk, and a door leading to the hall. No water though.");
                    Thread.Sleep(2000);
                    Console.WriteLine("What would you like to do?.");
                    Thread.Sleep(1000);
                    foreach (var room in Program.BedroomLocals)
                    {
                        Console.WriteLine($"- {room.Name}");
                    }
                    string roomChoices = Console.ReadLine()?.ToLower();
                    switch (roomChoices)
                    {
                        case :
                            
                            
                            break;
                        case "closet":
                            Room.LookThroughCloset();
                            break;
                        case "desk":
                            
                            
                            break;
                        case "door":
                            
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    break;
                case "2":
                    
                break;
                case "3":

                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }
    }
}
