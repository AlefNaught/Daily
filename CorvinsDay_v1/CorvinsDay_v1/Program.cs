using System;
using System.Collections.Generic;



namespace CorvinsDay_v1
{
    class Program
    {

        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();
        }

        static void Continue(string forward)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(forward);
            Console.ResetColor();
        }
        static void Character()
        {
            Dialog("Welcome to Corvin's Day. Now, you'll need a name.\nPlease enter it: ");
            string charName = Console.ReadLine();
            

            if (charName != "Corvin")
            {
                Dialog("No your name is Corvin.\n");
                Dialog("The game is called Corvin's Day you dumbass.\n");
                Continue("Press any key to continue...\n");
                Console.ReadLine();
                Dialog("Here, I'll just do it for since you're apparently autistic beyond belief.\n");
                Dialog(">string charName = 'Corvin'\n");
                Dialog("It was too easy, jesus.\n");
                charName = "Corvin";
                Continue("Press any key to continue...\n");
            }
            else
            {
                Dialog("Welcome to class Corvin.\n");
                Continue("Press any key to continue...\n");
                Console.ReadLine();
            }
            
        }

        
        /* Hack job while I figure lists out better... */
        public class Item
        {
            public Item()
            {
                List<string> itemsHeld = new List<string>();
                itemsHeld.Add("Rock");
                itemsHeld.Add("Knife");
                itemsHeld.Add("Shotgun");
                itemsHeld.Add("Pen");

                foreach (string i in itemsHeld)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
            
            
        }
        static void Main(string[] args)
        {
            Character();
            Item run = new Item(); //lmao
        }
        
        
        
    }
}