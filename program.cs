using System;

class Hello{
    public static void Main(){
        Console.WriteLine("Hello World");
        Console.WriteLine("Enter to continue");

        while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
    }
}