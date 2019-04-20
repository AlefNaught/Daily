using System;

namespace ConsoleApp
{
    class Program
    {
        delegate void delMyDelegate(object o);
        
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
                    bool guessRight = true;
                    Console.WriteLine("Correct.");
                }
                else
                {
                    Console.WriteLine("Guess again");
                }
            }
            
        }

        class DelegateTest //Figure out a better way to test this later.
        {
            private void MethodDel(object o)
            {
                Console.WriteLine("A delegate is a pointer to a method.");
            }

            private void MethodDel2(object o)
            {
                Console.WriteLine("We use it like this.");
            }

            private void MethodDelDo(delMyDelegate methodDelRun)
            {
                foreach (object o in theList)
                {
                    methodDelRun.Invoke(o);
                }
            }

            public void ApplyMethodsToList()
            {
                MethodDelDo(MethodDel);
                MethodDelDo(MethodDel2);
            }
            
        }
    }
}