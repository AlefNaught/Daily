using System;
using System.Collections.Generic;



namespace CorvinsDay_v1
{
    class Program
    {
        public void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();
        }

        public void Continue(string forward)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(forward);
            Console.ResetColor();
        }
        public void Character()
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
        public class Item
        {
            public string itemName { get; set; }
            public int itemId { get; set; }

            public void itemsInGame()
            {
                List<Item> items = new List<Item>();
                items.Add(new Item {itemId = 0, itemName = "Rock"});
                items.Add(new Item {itemId = 1, itemName = "Hammer"});
                items.Add(new Item {itemId = 2, itemName = "Sword"});
                items.Add(new Item {itemId = 3, itemName = "Shotgun"});

                foreach (var x in items)
                {
                    Console.WriteLine(x);
                }
            }
            public override string ToString()
            {
                return string.Join(", ", itemName);
            }
            
        }
        
        static void Main(string[] args)
        {
            Item runList = new Item();
            Program runProg = new Program();
           
            runProg.Character();
            runList.itemsInGame();

        }
        
        
        
    }
}