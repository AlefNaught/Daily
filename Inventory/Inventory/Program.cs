using System;
using System.Collections.Generic;

namespace Inventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("INVENTORY");
            string[] items = new string[] { "Saw", "Shotgun", "Bandage", "Hammer", "Beef", "Hat", "Water" };


            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            string itemSaw = items[0];
            string itemShotgun = items[1];
            string itemBandage = items[3];
            string itemHammer = items[4];
            string itemBeef = items[5];
            string itemHat = items[6];


            Console.WriteLine("Select an Item");

            string line = Console.ReadLine();

            switch (line)
            {
                case "Saw":
                        Console.WriteLine("You take out your Saw!");
                        break;
                case "Shotgun":
                        Console.WriteLine("You take out your Shotgun!");
                        break;
                case "Bandage":
                        Console.WriteLine("You take out your Bandages!");
                        break;
                case "Hammer":
                        Console.WriteLine("You take out your Hammer!");
                        break;
                case "Beef":
                        Console.WriteLine("You take out some Beef!");
                        break;
                case "Hat":
                        Console.WriteLine("You take out a Hat!");
                        break;
                case "Water":
                        Console.WriteLine("You take out some Water!");
                        break;

            }

            //Items currently held in hand by the player.
            Console.WriteLine("You are currently holding...");
            string[] itemsHeld = new string[] { line };
            foreach(string item in itemsHeld)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Continue for places to Explore.");
            Console.ReadLine();


            //End of Items Held.

            //Places to explore to test out Lists.

            List<string> placesAroundMe = new List<string>
            {
                "Northern House",
                "Eastern Apartments",
                "Southern Bridge",
                "Western Hospital"
            };

            placesAroundMe.ForEach(i => Console.WriteLine($"{i}\t"));

            Console.WriteLine("\n Type a place to go...");

            string pLine = Console.ReadLine();
            switch (pLine)
            {
                case "Northern House":
                case "North":
                case "House":
                    Console.WriteLine("You approach the Northern House...");
                    break;
                case "Eastern Apartments":
                case "East":
                case "Apartments":
                    Console.WriteLine("You approach the Eastern Apartments");
                    break;
                case "Southern Bridge":
                case "South":
                case "Bridge":
                    Console.WriteLine("You approach the Southern Bridge");
                    break;
                case "Western Hospital":
                case "West":
                case "Hospital":
                    Console.WriteLine("You approach the Western Hospital");
                    break;
            }



        }
    }
}
