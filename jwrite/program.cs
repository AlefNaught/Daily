using System;
using System.Windows.Forms;

class Hello{
    public static void Main(){
        Console.WriteLine("Hello World");
        Console.WriteLine("Enter to continue");

        while(Console.ReadKey(true).Key != ConsoleKey.Enter){}

        MessageBox.Show("Test");
        MessageBox.Show("Big boi test", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}