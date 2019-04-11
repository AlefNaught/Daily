using System;

namespace TextBasedAdventure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            gTitle();
        }

        public static void gTitle()
        {
            Console.WriteLine("Welcome to my game.");
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
            Console.Clear();
            first();

        }

        public static void first()
        {
            string choice;
            Console.WriteLine("You're standing in a field, your leg is bleeding.");
            Console.WriteLine("1. Bandage Leg.");
            Console.WriteLine("2. Saw Leg Off.");
            Console.WriteLine("3. Saw Arm Off.");
            Console.WriteLine("4. Kill Self.");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "bandage leg.":
                case "bandage":
                    {
                        Console.WriteLine("You wrap a bandage around your leg.");
                        Console.WriteLine("The bleeding stops.");
                        Console.WriteLine("You are okay.");
                        Console.WriteLine("You look around, there is a house to the left.");
                        Console.WriteLine("Press 'Enter' to Continue");
                        Console.ReadLine();
                        second();
                        break;
                    }

                case "2":
                case "Saw":
                case "Saw Leg off":
                    {
                        Console.WriteLine("You are now bleeding very heavily.");
                        Console.WriteLine("You amputated leg falls to the floor.");
                        Console.WriteLine("Everything slowly fades to black.");
                        Console.ReadLine();
                        gOver();
                        break;
                    }

            }
        }

        public static void second()
        {
            Console.WriteLine("You approach the house.");
            Console.WriteLine("It's freezing.");
            Console.WriteLine("There are three windows on this side of the building.");

        }

        public static void third()
        {

        }

        public static void gOver()
        {

        }

        public static void gWin()
        {

        }

    }
}
