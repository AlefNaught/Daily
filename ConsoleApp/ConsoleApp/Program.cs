using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            
            if(a <= 60 && b <= 60)
            {
                Console.WriteLine(a + b + " Less than 60");
            }
            else
            {
               Console.WriteLine("Is not less than 60");
            }

            int[] numArray = new int[]{15, 16, 20, 25, 18, 26};
            int pullArray = numArray.Length;
            Console.WriteLine(pullArray);

            if (pullArray >= 3)
            {
               Console.WriteLine("There are three or less elements in this array.");
            }
            else 
            {
                Console.WriteLine("There are more than 3 elements in this array");
            }
            Console.WriteLine("How many elements are in the array?");

            foreach(int numbers in numArray)
            {
                pullArray = Convert.ToInt32(Console.ReadLine());
                if (pullArray == numArray.Length)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Guess again");
                }
            }
            
        }
    }
}