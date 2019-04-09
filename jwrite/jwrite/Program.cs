using System;
using System.IO;
using System.Text;
namespace jwrite
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();
            StreamWriter writer = new StreamWriter("file.txt", false, Encoding.UTF8);
            writer.Write(text);

            writer.Close();


        }
    }
}
