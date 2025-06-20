using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rooms
    {
        public static void HallwayFlashOn()
        {
            Console.WriteLine("You walk into the hallway, the light from your phone illuminating the way.");
            Thread.Sleep(2500);
            Console.WriteLine("You look at your surroundings, remembering where everyone is sleeping.");
            Thread.Sleep(2500);
            Console.WriteLine("You see your parent's room, the bathroom, and your sibling's room.");
            Thread.Sleep(2500);
            Console.WriteLine("there are two staircases, one going up and one headed down.");
            Thread.Sleep(2500);
            Console.WriteLine("Where would you like to go?");
            Thread.Sleep(2500);
            Console.WriteLine("1. Check your parent's room");
            Thread.Sleep(1000);
            Console.WriteLine("2. Check the bathroom");
            Thread.Sleep(1000);
            Console.WriteLine("3. Check your sibling's room");
            Thread.Sleep(1000);
            Console.WriteLine("4. Go up");
            Thread.Sleep(1000);
            Console.WriteLine("5. Go down");
            string flashHallwayChoice = Console.ReadLine()?.ToLower();
            switch (flashHallwayChoice)
            {
                case "1":
                    ParentRoom();
                    break;
                case "2":
                    Bathroom();
                    break;
                case "3":
                    SiblingRoom();
                    break;
                case "4":
                    Attic();
                    break;
                case "5":
                    EntranceHallway();
                    break;
                case "g":
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (!Program.Inventory.Any())
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Your inventory is empty.");
                        Thread.Sleep(1000);
                        HallwayFlashOn();
                    }
                    else
                    {
                        Program.Inventory.ForEach(item => Console.WriteLine($"{item.Name}: {item.Description}"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        HallwayFlashOn();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Thread.Sleep(1000);
                    HallwayFlashOn();
                    break;
            }
        }

        public static void HallwayFlashOff()
        {
            Console.WriteLine("You walk out of your room, barely being able to think due to the sleepyness.");
            Thread.Sleep(2500);
            Console.WriteLine("You, in a sleep-filled haze, walk forward and forget there are stairs.");
            Thread.Sleep(2500);
            Console.WriteLine("You trip and fall down the stairs, hitting your head on the way down.");
            Thread.Sleep(3000);
            Nightmare.Coma();
        }

        public static void BedroomLocals()
        {
            Console.WriteLine("1. Check the closet");
            Thread.Sleep(1000);
            Console.WriteLine("2. Look under the bed");
            Thread.Sleep(1000);
            Console.WriteLine("3. Look on your desk");
            Thread.Sleep(1000);
            Console.WriteLine("4. Get out of your room");
            string bedroomLocals = Console.ReadLine()?.ToLower();
            switch (bedroomLocals)
            {
                case "1":
                    Thread.Sleep(100);
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You check the closet, Your clothes neatly folded and hung.");
                    Thread.Sleep(2500);
                    Console.WriteLine("There isn't a glass in here, I think that would be logical.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    BedroomLocals();
                    break;
                case "2":
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You look under the bed, but find nothing unusual.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You find some dust bunnies and a lost sock, but no empty glass.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    BedroomLocals();
                    break;
                case "3":
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You look on your desk, your familliar setup shining because of your phone light.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You see your laptop, some books, and a few pens.");
                    Thread.Sleep(2500);
                    Console.WriteLine("It seems you were busy with a school assignment, but that's for later.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You don't see a glass here either. Unfortunate you :(");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    BedroomLocals();
                    break;
                case "4":
                    Console.Clear();
                    HallwayFlashOn();
                    break;
                case "g":
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (!Program.Inventory.Any())
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Your inventory is empty.");
                        Thread.Sleep(1000);
                        BedroomLocals();
                    }
                    else
                    {
                        Program.Inventory.ForEach(item => Console.WriteLine($"{item.Name}: {item.Description}"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        BedroomLocals();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(1000);
                    BedroomLocals();
                    break;
            }
        }

        public static void ParentRoom()
        {
            Thread.Sleep(2500);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("Before you enter, would you like to dim your flashlight? (y/n)");
            string dimChoice = Console.ReadLine()?.ToLower();
            if (dimChoice == "y")
            {
                Console.Clear();
                Console.WriteLine("You dim your flashlight, making it less bright.");
                Thread.Sleep(1000);
                Console.WriteLine("You walk into your parent's room, the light from your phone illuminating the way.");
                Thread.Sleep(2500);
                Console.WriteLine("You see your mother sleeping peacefully.");
                Thread.Sleep(2500);
                Console.WriteLine("Your flashlight is dim enough for your mother to not notice you.");
                Thread.Sleep(2500);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("What would you like to do?");
                Thread.Sleep(2500);
                Console.WriteLine("1. Check the closet");
                Thread.Sleep(1000);
                Console.WriteLine("2. Check under the bed");
                Thread.Sleep(1000);
                Console.WriteLine("3. Check the desk");
                Thread.Sleep(1000);
                Console.WriteLine("4. Go back to the hallway");
                ParentRoomContinue();
            }
            else if (dimChoice == "n")
            {
                Nightmare.FlashOn();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(1000);
                ParentRoom();
            }
        }

        public static void ParentRoomContinue()
        {
            string parentRoomChoice = Console.ReadLine()?.ToLower();
            switch (parentRoomChoice)
            {
                case "1":
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You check the closet, but find nothing unusual.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Just some clothes and spare bedsheets, nothing that could help you.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You can't find a glass here, smhsmh.");
                    Console.Clear();
                    Thread.Sleep(1000);
                    ParentRoomContinue();
                    break;
                case "2":
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You look under the bed, but find nothing unusual.");
                    Thread.Sleep(2500);
                    Console.WriteLine("It's very clean under there, apart from dust scattered around.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You don't see a glass here though, rip.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    ParentRoomContinue();
                    break;
                case "3":
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You look on the desk, your father's work setup shining because of your phone light.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You see his pc, a fairly big monitor, and an office mouse.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You find an ashtray with cigarette buds in it, ew.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You don't see a glass here either, what a shame.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    ParentRoomContinue();
                    break;
                case "4":
                    Console.Clear();
                    HallwayFlashOn();
                    break;
                case "g":
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (!Program.Inventory.Any())
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Your inventory is empty.");
                        Thread.Sleep(1000);
                        ParentRoomContinue();
                    }
                    else
                    {
                        Program.Inventory.ForEach(item => Console.WriteLine($"{item.Name}: {item.Description}"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        ParentRoomContinue();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(1000);
                    ParentRoomContinue();
                    break;
            }
        }

        public static void Attic()
        {
            Program.atticRooms.Add(new Program.AtticRooms("1.", "Check the boxes"));
            Program.atticRooms.Add(new Program.AtticRooms("2.", "Check the furniture"));
            Program.atticRooms.Add(new Program.AtticRooms("3.", "Check the corner"));
            Program.atticRooms.Add(new Program.AtticRooms("4.", "Go back down"));
            Thread.Sleep(2500);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("You take the stairs towards the attic.");
            Thread.Sleep(2500);
            Console.WriteLine("The stairs creak under your weight, but you manage to reach the top.");
            Thread.Sleep(2500);
            Console.WriteLine("You open the attic door, revealing a dusty and dark space.");
            Thread.Sleep(2500);
            Console.WriteLine("You see old furniture, boxes, and a few cobwebs.");
            Thread.Sleep(2500);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("What would you like to do?");
            Thread.Sleep(2500);
            AtticContinue();
        }

        public static void AtticContinue()
        {
            foreach (var room in Program.atticRooms)
            {
                Console.WriteLine($"{room.ActionNumber} {room.ActionDescription}");
            }
            string atticChoice = Console.ReadLine()?.ToLower();
            switch (atticChoice)
            {
                case "1":
                    Program.atticRooms.RemoveAll(r => r.ActionDescription == "Check the boxes");
                    var item = new Program.inv("Old Glass", "A dusty but usable glass with a beautiful drawing covering it.");
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You check the boxes, and find something!");
                    Program.Inventory.Add(item);
                    Thread.Sleep(2500);
                    Console.WriteLine("You find an old glass, dusty but usable. A beautiful drawing covering the glass.");
                    Thread.Sleep(2500);
                    Console.WriteLine($"You take the glass. (item {item.Name} was added (G to view))");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    AtticContinue();
                    break;
                case "2":
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.WriteLine("You check the furniture, but find nothing unusual.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Just some old chairs and a table, nothing that could help you.");
                    Thread.Sleep(2500);
                    Console.WriteLine("The furniture is beautiful though.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    AtticContinue();
                    break;
                case "3":
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.WriteLine("You check the corner, but find nothing unusual.");
                    Thread.Sleep(2500);
                    Console.WriteLine("A spiderweb and an eerie feeling are found there.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You feel like something is watching you, but you shake it off.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    AtticContinue();
                    break;
                case "4":
                    Console.Clear();
                    Thread.Sleep(1000);
                    HallwayFlashOn();
                    break;
                case "g":
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (!Program.Inventory.Any())
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Your inventory is empty.");
                        Thread.Sleep(1000);
                        AtticContinue();
                    }
                    else
                    {
                        Program.Inventory.ForEach(item => Console.WriteLine($"{item.Name}: {item.Description}"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        AtticContinue();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(1000);
                    Attic();
                    break;
            }
        }

        public static void Bathroom()
        {
            if (Program.Inventory.Any(i => i.Name == "Old Glass"))
            {
                Console.Clear();
                Thread.Sleep(1000);
                Dream.DreamBathroomGlass();
            }
            else if (!Program.Inventory.Any(i => i.Name == "Old Glass"))
            {
                Thread.Sleep(2500);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("You walk into the bathroom, the light from your phone illuminating the way.");
                Thread.Sleep(2500);
                Console.WriteLine("You see the sink, the toilet, and a shower.");
                Thread.Sleep(2500);
                Console.WriteLine("You look around for a glass, but find nothing.");
                Thread.Sleep(2500);
                Console.WriteLine("There it is though, the sink.");
                Thread.Sleep(2500);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("You walk towards it, contemplating your life's actions.");
                Thread.Sleep(2500);
                Console.WriteLine("Will you really drink water without a glass? (y/n)");
                string bathroomChoice = Console.ReadLine()?.ToLower();
                if (bathroomChoice == "y")
                {
                    Dream.DreamBathroomNoGlass();
                }
                else if (bathroomChoice == "n")
                {
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.WriteLine("You decide to not go for it, and head back to the hallway.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    HallwayFlashOn();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1000);
                    Bathroom();
                }
            }
        }

        public static void SiblingRoom()
        {
            Thread.Sleep(2500);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("You walk into your sibling's room, the light from your phone illuminating the way.");
            Thread.Sleep(2500);
            Console.WriteLine("You see your sibling sleeping peacefully.");
            Thread.Sleep(2500);
            Console.WriteLine("Your sibling is a heavy sleeper, so the flashlight doesn't matter.");
            Thread.Sleep(2500);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("What would you like to do?");
            Thread.Sleep(2500);
            Console.WriteLine("1. Check the closet");
            Thread.Sleep(1000);
            Console.WriteLine("2. Check under the bed");
            Thread.Sleep(1000);
            Console.WriteLine("3. Check the desk");
            Thread.Sleep(1000);
            Console.WriteLine("4. Go back to the hallway");
            string siblingRoomChoice = Console.ReadLine()?.ToLower();
            switch (siblingRoomChoice)
            {
                case "1":
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You check the closet, but find nothing unusual.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Just some clothes and toys, nothing that could help you.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You can't find a glass here, what a bummer.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    SiblingRoom();
                    break;
                case "2":
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You look under the bed, but find nothing unusual.");
                    Thread.Sleep(2500);
                    Console.WriteLine("It's a mess under there, jeez man.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You don't see a glass here though, sadge.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    SiblingRoom();
                    break;
                case "3":
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You look on the desk, your sibling's setup shining because of your phone light.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You see their laptop, some notebooks and a pen.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You find an empty glass, but it's not usable. It's broken :(");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    SiblingRoom();
                    break;
                case "4":
                    Console.Clear();
                    HallwayFlashOn();
                    break;
                case "g":
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (!Program.Inventory.Any())
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Your inventory is empty.");
                        Thread.Sleep(1000);
                        SiblingRoom();
                    }
                    else
                    {
                        Program.Inventory.ForEach(item => Console.WriteLine($"{item.Name}: {item.Description}"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        SiblingRoom();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    SiblingRoom();
                    break;
            }
        }

        public static void EntranceHallway()
        {
            Program.Father.Add(new Program.father("1.", "What are YOU doing here?"));
            Program.Father.Add(new Program.father("2.", "What are you eating?"));
            Program.Father.Add(new Program.father("3.", "I need some water"));

            if (Program.Inventory.Any(i => i.Name == "Old Glass"))
            {
                Program.Father.Add(new Program.father("4.", "Look at this glass I got."));
                Program.Father.RemoveAll(r => r.ActionInt == "3.");
                EntranceHallwayContinue();
            }
            else
            {
                EntranceHallwayContinue();
            }
        }

        public static void EntranceHallwayContinue()
        {
            Thread.Sleep(2500);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("You walk down the stairs, the light from your phone illuminating the way.");
            Thread.Sleep(2500);
            Console.WriteLine("You reach the bottom of the stairs, and see the entrance hallway.");
            Thread.Sleep(2500);
            Console.WriteLine("You see the front door, a coat rack, and a shoe rack.");
            Thread.Sleep(2500);
            Console.WriteLine("But what's this? the living room lights are on?");
            Thread.Sleep(2500);
            Console.WriteLine("Would you like to investigate? (y/n)");
            string entranceChoice = Console.ReadLine()?.ToLower();
            switch (entranceChoice)
            {
                case "y":
                    Console.Clear();
                    Thread.Sleep(1000);
                    Character.FatherNotice();
                    break;
                case "n":
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.WriteLine("You decide to not investigate, and look through the hallway.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.WriteLine("You see the front door, a coat rack, and a shoe rack. Nothing special.");
                    Thread.Sleep(2500);
                    Console.WriteLine("You feel a bit uneasy, but you shake it off.");
                    Thread.Sleep(2500);
                    Console.WriteLine("After building up enough courage, you decide to enter the living room.");
                    Character.FatherNotice();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1000);
                    EntranceHallway();
                    break;
            }
        }
    }
}