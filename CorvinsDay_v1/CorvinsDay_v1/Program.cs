using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.XPath;


namespace CorvinsDay_v1
{
  
   public class Item
    {
        public string ItemName { get; set; }
        public bool IsHeld { get; set; }
        public override string ToString()
        {
            return string.Join(",", ItemName, IsHeld);
        }

        

    }

   class Program
   {
       public List<Item> onCharacter = new List<Item>(); 
       
       public void Inventory()
       {
            onCharacter.Add(new Item{IsHeld = false, ItemName = "Test0"});
            onCharacter.Add(new Item{IsHeld = false, ItemName = "Test1"});
            onCharacter.Add(new Item{IsHeld = false, ItemName = "Test2"});
            onCharacter.Add(new Item{IsHeld = false, ItemName = "Test3"});
 
       }

       public void GiveItem()
       {
           //Gets a random item.
           string[] randoItem = {"Sword", "Hammer", "Shotgun", "Knife"};
            Random r = new Random();
            int rnd = r.Next(randoItem.Length);
            onCharacter.Add(new Item{IsHeld = false, ItemName = randoItem[rnd]});
            Console.WriteLine(randoItem[rnd]);
            string takeI = "take";
            if (Console.ReadLine() == takeI)
            {
                takeI.ToUpper();
                onCharacter.Add(new Item {IsHeld = true, ItemName = randoItem[rnd]});
            }
            Console.WriteLine(randoItem[rnd]);
            foreach (var x in onCharacter)
            {
                Console.WriteLine(x);
            }
       }



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
        
        static void Main(string[] args)
        {
            Program runProg = new Program();
            runProg.Character();
            runProg.Inventory();
            runProg.GiveItem();
        }
        
        
        
    }
}