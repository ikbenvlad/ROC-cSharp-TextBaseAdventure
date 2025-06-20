using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static List<inv> Inventory = new List<inv>();
        public static List<AtticRooms> atticRooms = new List<AtticRooms>();
        public static List<father> Father = new List<father>();

        public static string Name { get; set; } = "child";
        static void Main()
        {
            Console.WriteLine("Please enter your name...");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Name = "child";
            }
            else
            {
                Name = input;
            }

            Console.WriteLine($"Welcome, {Name}.");
            Thread.Sleep(1000);
            Console.WriteLine("Today was a long day, try to get some rest.");
            Thread.Sleep(1000);
            Console.WriteLine("You eventually fade off to sleep.");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(4000);
            Console.Clear();
            WakingUp.WokeUp();
        }

        public class inv
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public inv(string name, string description)
            {
                Name = name;
                Description = description;
            }
        }

        public class AtticRooms
        {
            public string ActionNumber { get; set; }
            public string ActionDescription { get; set; }
            public AtticRooms(string number, string actionDescription)
            {
                ActionNumber = number;
                ActionDescription = actionDescription;
            }
        }

        public class father
        {
            public string ActionInt { get; set; }
            public string ActionDescript { get; set; }
            public father(string name, string description)
            {
                ActionInt = name;
                ActionDescript = description;
            }
        }

    }
}
