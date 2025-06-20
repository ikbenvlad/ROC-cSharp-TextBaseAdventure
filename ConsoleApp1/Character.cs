using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Character
    {
        public static void FatherNotice()
        {
            Console.Clear();
            Console.WriteLine("You Look around, and find your Father sitting at the dinner table.");
            Thread.Sleep(2500);
            Console.WriteLine("He looks tired, but he's eating a small sandwich.");
            Thread.Sleep(2500);
            Console.WriteLine("You decide greet him, despite being tired yourself.");
            Thread.Sleep(2500);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine($"Oh, hey {Program.Name}. What are you doing here awake?");
            Thread.Sleep(2500);
            FatherNoticeContinue();
        }

        public static void FatherNoticeContinue()
        {
            foreach (var option in Program.Father)
            {
                Console.WriteLine($"{option.ActionInt} {option.ActionDescript}");
            }
            string choice = Console.ReadLine()?.ToLower();
            switch (choice)
            {
                case "1":
                    Program.Father.RemoveAll(r => r.ActionInt == "1.");
                    Console.Clear();
                    Console.WriteLine("Father: I gotta head out for work later. You should be sleeping, it's like 03:30 on a school night.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You look at the clock. It is indeed 03:30 AM.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You both sit in silence for a moment, enjoying the quiet of the night.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    FatherNoticeContinue();
                    break;
                case "2":
                    Program.Father.RemoveAll(r => r.ActionInt == "2.");
                    Console.Clear();
                    Console.WriteLine("Father: Oh, just a ham and cheese sandwich. Nothing special, I'll probably eat later at work");
                    Thread.Sleep(2500);
                    Console.WriteLine("You look at the ham and cheese sandwich. You don't need food right now.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    FatherNoticeContinue();
                    break;
                case "3":
                    Program.Father.RemoveAll(r => r.ActionInt == "3.");
                    Console.Clear();
                    Console.WriteLine("Father: well, the sink is right there. You can grab a cup from one of the cupboards.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Holy shit.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Water.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Dream.DreamCuppaWater();
                    break;
                case "4":
                    Program.Father.RemoveAll(r => r.ActionInt == "4.");
                    Console.Clear();
                    Console.WriteLine("Father: Well damn, I haven't seen that in a while.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Father: It's the glass I bought for your mother back when we were still dating.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Father: Ahh, good memories.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Dream.DreamTheGloriousCup();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                    FatherNotice();
                    break;
            }
        }
    }
}
