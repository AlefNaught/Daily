using System;

namespace Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int xs = 0;
            int ys = 0;
            
            Console.WriteLine("Enter the X and the Y and see if its perfectly balanced.");
            char[] userInput = Console.ReadLine().ToCharArray();

            foreach (char c in userInput)
            {
                if (c == 'x')
                {
                    xs++;
                }
                else if (c == 'y') ;
                {
                    ys++;
                }
            }
            if (xs == ys)
            {
                Console.WriteLine("Perfectly Balanced");
            }
            else
            {
                Console.WriteLine("Not Balanced.");
            }
        }
    }
}