using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml;
using System.Xml.XPath;


namespace CorvinsDay_v1
{
  
   public static class Items
    {
        static public List<Item> items;
        static public void ItemsInGame()
        {
            items.Add(new Item{ItemName = "Rock"});
            items.Add(new Item{ItemName = "Bird"});
            items.Add(new Item{ItemName = "Dildo"}); 
            items.Add(new Item{ItemName = "Your mom"});
        }
    }
   public class Item
    {
        public static List<Item> items;
        public string ItemName { get; set; }
        public override string ToString()
        {
            return string.Join(",", ItemName);
        }
    }
    class Program
    {

        public void Inventory()
        {
            List<Item> onCharacter = new List<Item>();
           
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


        }
        
        
        
    }
}